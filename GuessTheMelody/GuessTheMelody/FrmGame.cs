using System;
using System.Media;
using System.Windows.Forms;
using WMPLib;

namespace GuessTheMelody
{
    public partial class FrmGame : Form
    {
        Random rand = new Random();
        private int musicDuration = Victorina.MusicDuration;
        
        // массив флагов
        // если один из игроков ответил неправильно, то он уже не может ответить на текущую песню
        bool[] players = new bool[2];
        
        public FrmGame()
        {
            InitializeComponent();
        }

        private void FrmGame_Load(object sender, EventArgs e)
        {
            lblSongsCounter.Text = Victorina.TrackList.Count.ToString();
            progressBar1.Value = 0;
            progressBar1.Maximum = Victorina.GameDuration;
            lblMusicDuration.Text = musicDuration.ToString();
        }

        private void FrmGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            GameStop();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MakeMusic();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            GamePause();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            GamePlay();
        }

        /// <summary>
        /// Прослушать мелодию
        /// </summary>
        void MakeMusic()
        {
            if (Victorina.TrackList.Count == 0)
            {
                GameStop();
            }
            else
            {
                musicDuration = Victorina.MusicDuration;
                int n = rand.Next(0, Victorina.TrackList.Count);
                WMP.URL = Victorina.TrackList[n];
                Victorina.Answer = WMP.URL;
                // wmp.Ctlcontrols.play(); // для автоматической игры
                Victorina.TrackList.RemoveAt(n);
                lblSongsCounter.Text = Victorina.TrackList.Count.ToString();
                players[0] = false;
                players[1] = false;
            }
        }

        /// <summary>
        /// Продолжить/начать проигрывание 
        /// </summary>
        private void GamePlay()
        {
            timer1.Start();
            WMP.Ctlcontrols.play();
        }

        /// <summary>
        /// Пауза в проигрывании 
        /// </summary>
        private void GamePause()
        {
            timer1.Stop();
            WMP.Ctlcontrols.pause();
        }

        /// <summary>
        /// Остановить проигрывание 
        /// </summary>
        private void GameStop()
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            musicDuration--;
            lblMusicDuration.Text = musicDuration.ToString();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                GameStop();
                SoundPlayer sp = new SoundPlayer(Properties.Resources.instrument_fast);
                sp.Play();
                return;
            }
            if (musicDuration == 0) MakeMusic();
            
        }

        private void FrmGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (timer1.Enabled && e.KeyData == Keys.Space)
            {
                btnPause_Click(this, EventArgs.Empty);
                return;
            }
            // TODO: Обработать нажатие клавиши пробела
            if (!timer1.Enabled && e.KeyData == Keys.Space && WMP.playState == WMPPlayState.wmppsPaused)
            {
                btnContinue_Click(this, EventArgs.Empty);
                return;
            }
            if (!timer1.Enabled) return;
            if (players[0] == false && e.KeyData == Keys.Q) // Игрок 1
            {
                GamePause();
                FrmMessage message = new FrmMessage();
                message.label1.Text = "Игрок 1";
                players[0] = true;
                if (message.ShowDialog() == DialogResult.Yes) /* MessageBox.Show("Правильный ответ?", "Игрок 1", MessageBoxButtons.YesNo) == DialogResult.Yes*/
                {
                    lblCounter1.Text = (Convert.ToInt32(lblCounter1.Text) + 1).ToString();
                    MakeMusic();
                }
                GamePlay();
            }
            if (players[1] == false && e.KeyData == Keys.P) // Игрок 2
            {
                GamePause();
                FrmMessage message = new FrmMessage();
                message.label1.Text = "Игрок 2";
                players[1] = true;
                if (message.ShowDialog() == DialogResult.Yes) /*MessageBox.Show("Правильный ответ?", "Игрок 2", MessageBoxButtons.YesNo) == DialogResult.Yes*/
                {
                    lblCounter2.Text = (Convert.ToInt32(lblCounter2.Text) + 1).ToString();
                    MakeMusic();
                }
                GamePlay();
            }
        }

        private void WMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Victorina.RandomStart)
            {
                if (WMP.openState == WMPOpenState.wmposMediaOpen)
                {
                    WMP.Ctlcontrols.currentPosition = rand.Next(0, (int) (WMP.currentMedia.duration / 2));
                }
            }
        }
    }
}
