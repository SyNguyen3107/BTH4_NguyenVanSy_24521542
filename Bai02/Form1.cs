
using System.Globalization;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Simple Clock";

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object? sender, System.EventArgs e)
        {
            DateTime now = DateTime.Now;
            string timeString = now.ToString("dddd, MMMM dd, yyyy hh:mm:ss tt", new CultureInfo("en-US"));
            label1.Text = timeString;
        }
    }
}
