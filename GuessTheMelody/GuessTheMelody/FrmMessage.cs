using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GuessTheMelody
{
    public partial class FrmMessage : Form
    {
        private int timeAnswer = 5;
        public FrmMessage()
        {
            InitializeComponent();
        }

        private void FrmMessage_Load(object sender, EventArgs e)
        {
            timeAnswer = 5;
            lblTime.Text = timeAnswer.ToString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeAnswer--;
            lblTime.Text = timeAnswer.ToString();
            if (timeAnswer == 0)
            {
                timer1.Stop();
                SoundPlayer sp = new SoundPlayer(Properties.Resources.instrument_fast);
                sp.Play();
            }
        }

        private void FrmMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
    }
}
