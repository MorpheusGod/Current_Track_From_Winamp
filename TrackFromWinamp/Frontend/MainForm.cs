using System;
using System.Windows.Forms;
using TrackFromWinamp.Backend;

namespace TrackFromWinamp
{
    public partial class MainForm : Form
    {
        CurrentTrack track;
        Timer timer;

        public MainForm()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 500;
            track = new CurrentTrack();
            StopWork.Enabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
           if(TrackName.Text != track.GetSongTitle())
            {
                TrackName.Text = track.GetSongTitle();
            }
        }

        private void StartWork_Click(object sender, System.EventArgs e)
        {
            timer.Start();
            StartWork.Enabled = false;
            StopWork.Enabled = true;
        }

        private void StopWork_Click(object sender, System.EventArgs e)
        {
            timer.Stop();
            TrackName.Text = "Программа не запущена или остановлена.";
            StartWork.Enabled = true;
            StopWork.Enabled = false;
        }
    }
}
