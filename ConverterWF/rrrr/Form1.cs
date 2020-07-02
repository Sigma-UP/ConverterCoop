//C# 8.0
//Visual Studio 2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Screamer;

namespace Converter_WF
{
	public partial class Form1 : Form
	{
		int chsnIndex;  // currency index for conversion
		string current; // current currency name to convert
		
		private List<string> currencies = new List<string> { 
			"USD", "EUR", "UAH", 
			"PLN", "BYR", "CNY", 
			"RUB" };
		

		public Form1()
		{
			InitializeComponent();

			object[] arr = new object[currencies.Count()];
			for(int i = 0; i < currencies.Count(); i++)
				arr[i] = currencies[i];
			cbFrom.Items.AddRange(arr);

			
			dgv.Columns.Add("crrName", "CURRENCY");
			dgv.Columns[0].ReadOnly = true;

			dgv.Columns.Add("rare", "RARE");
			dgv.Columns[0].ReadOnly = false;

			dgv.Columns.Add("result", "RESULT");
			dgv.Columns[2].ReadOnly = true;
		
			for (int i = 0; i < currencies.Count() - 1; i++)
				dgv.Rows.Add();

			cbFrom.SelectedIndex = 0;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void cbFrom_SelectedIndexChanged(object sender, EventArgs e)
		{
			chsnIndex = cbFrom.SelectedIndex;
			current = currencies[chsnIndex];

			swap_last(currencies, chsnIndex);

			lbl_currInvitation.Text = $"Enter amount of {current}";
			

			for (int i = 0; i < currencies.Count() - 1; i++)
			{
				dgv.Rows[i].Cells[0].Value = currencies[i];
				dgv.Rows[i].Cells[1].Value = "1,0000";
			}

			swap_last(currencies, chsnIndex);
		}
		private void tbx_KeyPress(object sender, KeyPressEventArgs e) {positive_num_check(e); }
		
		private void btn_convert_click(object sender, EventArgs e)
		{
			for (int i = 0; i < dgv.RowCount; i++)
				dgv.Rows[i].Cells["RESULT"].Value =
					(Convert.ToDouble(tbx_currVal.Text) * Convert.ToDouble(dgv.Rows[i].Cells["RARE"].Value)).ToString("0.0000");
		}

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
    }
}
