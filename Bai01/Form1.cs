namespace Bai01
{
    public partial class Form1 : Form
    {
        private string keyInfo = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            string message = $"Bạn vừa click chuột tại vị trí: ({x}, {y})";
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            keyInfo += "Key code: " + e.KeyCode + "\n";
            keyInfo += "Key value: " + e.KeyValue + "\n";
            keyInfo += "Modifiers: " + e.Modifiers + "\n";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyInfo += "Key char: " + e.KeyChar + "\n";
            keyInfo += "ASCII: " + (int)e.KeyChar + "\n";
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            MessageBox.Show(keyInfo, "Thông tin phím đã nhấn\n", MessageBoxButtons.OK, MessageBoxIcon.Information);
            keyInfo = "";
        }
    }
}
