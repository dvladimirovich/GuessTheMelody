using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using TagLib;

namespace GuessTheMelody
{
    public partial class FrmMessage : Form
    {
        private int timeAnswer = 10;
        private string showAnswer = "Показать ответ";
        public FrmMessage()
        {
            InitializeComponent();
        }

        private void FrmMessage_Load(object sender, EventArgs e)
        {
            timeAnswer = 10;
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

        private void lblShowAnswer_Click(object sender, EventArgs e)
        {
            
        }

        private void lblShowAnswer_MouseEnter(object sender, EventArgs e)
        {
            if (lblShowAnswer.Text == showAnswer)
            {
                lblShowAnswer.ForeColor = SystemColors.Highlight;
                lblShowAnswer.Cursor = Cursors.Hand;
            }
        }

        private void lblShowAnswer_MouseClick(object sender, MouseEventArgs e)
        {
            if (lblShowAnswer.Text == showAnswer)
            {
                var mp3File = File.Create(Victorina.Answer);
                lblShowAnswer.Text = mp3File.Tag.FirstPerformer + " - " + mp3File.Tag.Title;
                lblShowAnswer.ForeColor = SystemColors.ControlText;
                lblShowAnswer.Cursor = Cursors.Default;
                lblShowAnswer.Font = new Font(lblShowAnswer.Font.FontFamily,lblShowAnswer.Font.Size, FontStyle.Regular);
            }
        }

        private void lblShowAnswer_MouseLeave(object sender, EventArgs e)
        {
            lblShowAnswer.ForeColor = SystemColors.ControlText;
            lblShowAnswer.Cursor = Cursors.Default;
        }
    }
}
