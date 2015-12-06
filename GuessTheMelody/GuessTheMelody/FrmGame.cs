using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheMelody
{
    public partial class FrmGame : Form
    {
        Random rand = new Random();
        public FrmGame()
        {
            InitializeComponent();
        }

        private void FrmGame_Load(object sender, EventArgs e)
        {
            lblSongsCounter.Text = Victorina.TrackList.Count.ToString();
            progressBar1.Value = 0;
            progressBar1.Maximum = Victorina.GameDuration;
        }

        private void FrmGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            StopPlaying();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            timer1.Start();
            MakeMusic();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            WMP.Ctlcontrols.pause();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            timer1.Start();
            WMP.Ctlcontrols.play();
        }

        /// <summary>
        /// Прослушать мелодию
        /// </summary>
        void MakeMusic()
        {
            int n = rand.Next(0, Victorina.TrackList.Count);
            WMP.URL = Victorina.TrackList[n];
            // wmp.Ctlcontrols.play(); // для автоматической игры
            Victorina.TrackList.RemoveAt(n);
            lblSongsCounter.Text = Victorina.TrackList.Count.ToString();
        }

        /// <summary>
        /// Остановить проигрывание 
        /// </summary>
        private void StopPlaying()
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
            {
                StopPlaying();
                return;
            }
            progressBar1.Value++;
        }
    }
}
