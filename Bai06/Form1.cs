using System.IO;
using System.Threading.Tasks;

namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void opensrc_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Chọn thư mục nguồn chứa các file";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                source_tb.Text = fbd.SelectedPath;
            }
        }

        private void opendest_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Chọn thư mục đích";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                dest_tb.Text = fbd.SelectedPath;
            }
        }

        private void copy_btn_Click(object sender, EventArgs e)
        {
            copyFile();
        }
        private async void  copyFile()
        {
            string sourcePath = source_tb.Text;
            string destDir = dest_tb.Text;
            if (string.IsNullOrEmpty(sourcePath) || string.IsNullOrEmpty(destDir))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ đường dẫn nguồn và đích!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!Directory.Exists(sourcePath))
            {
                MessageBox.Show("Thư mục nguồn không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Directory.Exists(destDir))
            {
                MessageBox.Show("Thư mục đích không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] files = Directory.GetFiles(sourcePath);
            progressBar1.Minimum = 0;
            progressBar1.Maximum = files.Length;
            progressBar1.Value = 0;
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string destPath = Path.Combine(destDir, fileName);

                status_lb.Text = "Đang sao chép: " + sourcePath;

                toolTip1.SetToolTip(progressBar1, "Đang sao chép: " + sourcePath);

                await Task.Run(() =>
                {
                    // Copy file, true nghĩa là ghi đè nếu file đã tồn tại
                    File.Copy(file, destPath, true);
                });
                progressBar1.Value += 1;
                await Task.Delay(50);
            }
            MessageBox.Show("Đã sao chép xong toàn bộ tập tin.");
            status_lb.Text = "Hoàn tất.";
            progressBar1.Value = 0;
        }
    }
}
