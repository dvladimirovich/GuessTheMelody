using System;
using System.IO;
using System.Windows.Forms;

namespace GuessTheMelody
{
    public partial class FrmParams : Form
    {
        public FrmParams()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string[] musicArray = Directory.GetFiles(fbd.SelectedPath, "*.mp3",
                                                             chkbAllDirectories.Checked
                                                                 ? SearchOption.AllDirectories
                                                                 : SearchOption.TopDirectoryOnly);
                    lbMusicTrack.Items.Clear();
                    lbMusicTrack.Items.AddRange(musicArray);
                    Victorina.TrackList.Clear();
                    Victorina.TrackList.AddRange(musicArray);
                }
            }
        }
    }
}
