//C# 8.0
//Visual Studio 2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Screamer;

namespace Converter_WF
{
	public partial class Form1 : Form
	{
		int chsnIndex;  // currency index for conversion
		string current; // current currency name to convert
		const string databasePath = "database.txt";

		private List<string> currencies = new List<string>();

		public Form1()
		{
			InitializeComponent();

			dgv.Columns.Add("currencyName", "CURRENCY");
			dgv.Columns[0].ReadOnly = true;

			dgv.Columns.Add("rare", "RARE");
			dgv.Columns[1].ReadOnly = true;

			dgv.Columns.Add("result", "RESULT");
			dgv.Columns[2].ReadOnly = true;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			if (LoadDataBase(databasePath))
				return;

			MessageBox.Show
				(
				"Failed to read the database. Default currencies will be loaded", 
				"Error", 
				MessageBoxButtons.OK
				);

			string[] defCrncs = new string[] { "USD", "EUR", "UAH", "PLN", "BYR", "CNY", "RUB" };
			foreach (string crnc in defCrncs)
				AddCrnc(crnc);
		}

		private void cbFrom_SelectedIndexChanged(object sender, EventArgs e)
		{
			dgv.Columns[1].ReadOnly = false;
				

			if (cbFrom.SelectedIndex == -1)
				return;

			chsnIndex = cbFrom.SelectedIndex;
			current = currencies[chsnIndex];

			swap_last(currencies, chsnIndex);

			lbl_currInvitation.Text = $"Enter amount of {current}:";
			

			for (int i = 0; i < currencies.Count() - 1; i++)
			{
				dgv.Rows[i].Cells["currencyName"].Value = currencies[i];
				dgv.Rows[i].Cells["rare"].Value = "0,0000";
				dgv.Rows[i].Cells["result"].Value = "0,0000";
			}

			if (dgv.Rows.Count == currencies.Count) 
				dgv.Rows.Remove(dgv.Rows[currencies.Count - 1]);
			swap_last(currencies, chsnIndex);
		}
		private void tbx_KeyPress(object sender, KeyPressEventArgs e) {positive_num_check(e); }
		
		private void swap_last(List<string> list, int swap_index)
		{
			string tmp = list[list.Count() - 1];
			list[list.Count() - 1] = list[swap_index];
			list[swap_index] = tmp;
		}
	
		private KeyPressEventArgs positive_num_check(KeyPressEventArgs e)
		{
			char key = e.KeyChar;
			if (!Char.IsDigit(key) && key != 8 && key != 44)
				e.Handled = true;
			return e;
		}
	
        private void btn_screamer_Click(object sender, EventArgs e)
        {
			ScreamerForm form = new ScreamerForm();
			form.ShowDialog();
			form.Stop();
        }

		private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			double value = 0;
			bool isOk = true;

			try
			{
				value = Convert.ToDouble(dgv[1, e.RowIndex].Value);
			}
			catch
			{
				isOk = false;
			}

			if (!isOk || value < 0)
            {
				MessageBox.Show("Wrong data type.");
				dgv[1, e.RowIndex].Value = 0;
			}
			else
            {
				ConvertRow(e.RowIndex);
            }

		}

		void ConvertRow(int rowId)
        {
			double srcCrncValue = double.Parse(tbx_currVal.Text);
			double crncRate = Convert.ToDouble(dgv.Rows[rowId].Cells["RARE"].Value);

			dgv.Rows[rowId].Cells["result"].Value = (srcCrncValue * crncRate).ToString("0.0000");
		}

		void AddCrnc(string name)
		{
			currencies.Add(name);
			cbFrom.Items.Add(name);
			dgv.Rows.Add();

			for (int i = 0; i < dgv.Rows.Count; i++) 
			{
				dgv.Rows[i].Cells["currencyName"].Value = currencies[i];
				dgv.Rows[i].Cells["rare"].Value = "0,0000";
				dgv.Rows[i].Cells["result"].Value = "0,0000";
			}
		}

		private bool LoadDataBase(string path)
		{
			StreamReader sr;
			
			try
			{
				sr = new StreamReader(path);
			}
			catch
			{
				return false;
			}

			string line;
			while ((line = sr.ReadLine()) != null)
				if (line.Length == 3)
					AddCrnc(line);

			sr.Close();
			return true;
		}

		private void SaveDataBase(string path)
		{
			StreamWriter sw;

			try
			{
				sw = new StreamWriter(path);
			}
			catch (Exception ex)
			{
				MessageBox.Show("DataBase write error: " + ex.Message, "Error", MessageBoxButtons.OK);
				return;
			}

			foreach (string item in currencies)
				sw.WriteLine(item);

			sw.Close();
		}

		private void btn_AddCurrency_Click(object sender, EventArgs e)
        {
			AddCrncForm addCrncForm = new AddCrncForm();
			addCrncForm.ShowDialog();

			if (addCrncForm.DialogResult == DialogResult.OK)
				if (!currencies.Contains(addCrncForm.crncName))
					AddCrnc(addCrncForm.crncName);
				else
					MessageBox.Show("Same currency has already been added", "Error", MessageBoxButtons.OK);

			SaveDataBase(databasePath);
		}

        private void tbx_currVal_TextChanged(object sender, EventArgs e)
        {
			double srcCrncValue;
			if (!double.TryParse(tbx_currVal.Text, out srcCrncValue))  
				return;

			for (int i = 0; i < dgv.RowCount; i++)
				ConvertRow(i);
		}
    }
}
