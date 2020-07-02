using System;
using System.Windows.Forms;

namespace Converter_WF
{
    public partial class AddCrncForm : Form
    {
        public string crncName;

        public AddCrncForm()
        {
            InitializeComponent();
        }


        private void tBox_crncName_TextChanged(object sender, EventArgs e)
        {
            if (tBox_crncName.Text.Length >= 4)
                tBox_crncName.Text = tBox_crncName.Text.Remove(3);

            tBox_crncName.Text = tBox_crncName.Text.ToUpper();
            crncName = tBox_crncName.Text;

            tBox_crncName.SelectionStart = tBox_crncName.Text.Length;
            tBox_crncName.SelectionLength = 0;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (tBox_crncName.Text.Length != 3)
            {
                MessageBox.Show("Invalid Currency Code", "Error", MessageBoxButtons.OK);
                return;
            }

            DialogResult = DialogResult.OK;
        }

    }
}
