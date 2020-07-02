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
		
		private List<Label>     lbl_convertRare;
		private List<TextBox>   tbx_convertRare;
		private List<Label>     lbl_result;
		private List<TextBox>   tbx_result;


		public Form1()
		{
			InitializeComponent();

			object[] arr = new object[currencies.Count()];
			for(int i = 0; i < currencies.Count(); i++)
				arr[i] = currencies[i];

			cbFrom.Items.AddRange(arr);
			
			lbl_convertRare = new List<Label>     { lbl_convTo1, lbl_convTo2, lbl_convTo3, lbl_convTo4, lbl_convTo5, lbl_convTo6 };
			tbx_convertRare = new List<TextBox>   { tb_convTo1, tb_convTo2, tb_convTo3, tb_convTo4, tb_convTo5, tb_convTo6};
			lbl_result		= new List<Label>     { lbl_result1, lbl_result2, lbl_result3, lbl_result4, lbl_result5, lbl_result6 };
			tbx_result		= new List<TextBox>   { tbx_result1, tbx_result2, tbx_result3, tbx_result4, tbx_result5, tbx_result6 };
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			cbFrom.SelectedIndex = 0;
		}

		private void cbFrom_SelectedIndexChanged(object sender, EventArgs e)
		{

			chsnIndex = cbFrom.SelectedIndex;
			current = currencies[chsnIndex];


			swap_last(currencies, chsnIndex);

			lbl_currInvitation.Text = $"Enter amount of {current}";

			lbl_rareDescription.Text = $"{current}";

			lbl_convDescription.Text = $"{current}";
			
			tbx_result0.Text = $"{tbx_currVal.Text}";


			for (int i = 0; i <= lbl_convertRare.Count() - 1; i++)
			{
				lbl_convertRare[i].Text = currencies[i];
				tbx_convertRare[i].Text = "1,00";
			}

			for (int i = 0; i <= tbx_result.Count() - 1; i++)
			{
				lbl_result[i].Text = currencies[i];
				tbx_result[i].Text = "1,00";
			}
			swap_last(currencies, chsnIndex);
		}


		private void tbx_currVal_TextChanged(object sender, EventArgs e) { tbx_result0.Text = $"{tbx_currVal.Text}"; }

		private void tbx_KeyPress(object sender, KeyPressEventArgs e) {positive_num_check(e); }
		
		private void btn_convert_click(object sender, EventArgs e)
		{
			for (int i = 0; i <= tbx_result.Count() - 1; i++)
				tbx_result[i].Text =
					(Convert.ToDouble(tbx_currVal.Text) * Convert.ToDouble(tbx_convertRare[i].Text)).ToString("0.00");
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
