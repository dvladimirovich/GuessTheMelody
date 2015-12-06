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

        private void FrmParams_Load(object sender, EventArgs e)
        {
            SetParams();
            lbMusicTrack.Items.Clear();
            lbMusicTrack.Items.AddRange(Victorina.TrackList.ToArray());
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Victorina.AllDirectories = chkbAllDirectories.Checked;
            Victorina.RandomStart = chkbRandomStart.Checked;
            Victorina.GameDuration = Convert.ToInt32(cbGameDuration.Text);
            Victorina.MusicDuration = Convert.ToInt32(cbMusicDuration.Text);
            Victorina.SaveParam();
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetParams();
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
                    Victorina.LastFolder = fbd.SelectedPath;
                    lbMusicTrack.Items.Clear();
                    lbMusicTrack.Items.AddRange(musicArray);
                    Victorina.TrackList.Clear();
                    Victorina.TrackList.AddRange(musicArray);
                }
            }
        }

        private void SetParams()
        {
            chkbAllDirectories.Checked = Victorina.AllDirectories;
            chkbRandomStart.Checked = Victorina.RandomStart;
            cbGameDuration.Text = Victorina.GameDuration.ToString();
            cbMusicDuration.Text = Victorina.MusicDuration.ToString();
        }

    }
}
