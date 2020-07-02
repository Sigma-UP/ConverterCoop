using System;
using System.Windows.Forms;
using System.Media;

namespace Screamer
{
    public partial class ScreamerForm : Form
    {
        int imgId = 0;
        SoundPlayer player;

        public ScreamerForm()
        {
            InitializeComponent();
            Icon = Properties.Resources.ico;
            MaximumSize = Size;
            MinimumSize = Size;

            player = new SoundPlayer(Properties.Resources.sound);
            player.Play();

            timer.Start();
        }

        public void Stop()
        {
            player.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (imgId == 0)
            {
                imgId = 1;
                pictureBox1.Image = Properties.Resources.img;
            }
            else
            {
                imgId = 0;
                pictureBox1.Image = Properties.Resources.imgNow;
            }

        }
    }
}
