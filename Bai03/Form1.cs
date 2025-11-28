using System.Globalization;
using Timer = System.Windows.Forms.Timer;

namespace Bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Media Files|*.mp3;*.mp4;*.wav;*.avi;*.mkv;*.wmv|All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog.FileName;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            dateTime_sts.Items[0].Text = "Hôm nay là ngày " +  DateTime.Now.ToString("d") + " - Bây giờ là " + DateTime.Now.ToString("T");
        }
    }
}
