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

        private void btnNext_Click(object sender, EventArgs e)
        {
            MakeMusic();
        }

        void MakeMusic()
        {
            int n = rand.Next(0, Victorina.TrackList.Count);
            WMP.URL = Victorina.TrackList[n];
            // wmp.Ctlcontrols.play(); // для автоматической игры
            Victorina.TrackList.RemoveAt(n);
        }

        private void FrmGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Остановить проигрывание 
            WMP.Ctlcontrols.stop();
        }
    }
}
