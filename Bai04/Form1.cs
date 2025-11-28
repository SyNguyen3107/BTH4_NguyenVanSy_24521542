
using System.Collections;
using System.Drawing.Text; // Thư viện chứa InstalledFontCollection
namespace Bai04
{
    public partial class Form1 : Form
    {
        int defaultFontSize = 14;
        string defaultFont;
        private string currentFilePath = "";// Nếu rỗng ("") nghĩa là văn bản mới chưa từng được lưu.
        public Form1()
        {
            InitializeComponent();
            InstalledFontCollection installedFonts = new InstalledFontCollection();
            foreach (FontFamily font in installedFonts.Families)
            {
                toolStrip_fontFamily_cbb.Items.Add(font.Name);
                if (font.Name == "Tahoma")
                {
                    defaultFont = font.Name;
                }
            }
            string[] sizeList = { "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72" };
            toolStrip_fontSize_cbb.Items.AddRange(sizeList);
            toolStrip_fontFamily_cbb.SelectedItem = defaultFont;
            toolStrip_fontSize_cbb.Text = defaultFontSize.ToString();
            richTextBox1.Font = new Font(defaultFont, defaultFontSize, FontStyle.Regular);
            richTextBox1.Modified = false;
        }
        private void resetContent()
        {

            if (confirmSave() == false) return;

            richTextBox1.Clear();
            richTextBox1.Modified = false;
            currentFilePath = "";
            toolStrip_fontFamily_cbb.SelectedItem = defaultFont;
            toolStrip_fontSize_cbb.Text = defaultFontSize.ToString();
            richTextBox1.Font = new Font(defaultFont, defaultFontSize, FontStyle.Regular);
        }
        private bool isSaved()
        {
            return !string.IsNullOrEmpty(currentFilePath);
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!confirmSave())//Nếu người dùng hủy thao tác (chọn No/đóng cửa sổ Confirm)
                return;
            this.Close();
        }
        private bool confirmSave()
        {
            if (richTextBox1 != null && richTextBox1.Modified)
            {
                DialogResult result = MessageBox.Show("Văn bản chưa được lưu. Bạn có muốn lưu thay đổi không?", "Xác nhận",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Nếu chọn Yes -> Gọi hàm lưu. Nếu lưu thành công thì trả về true.
                    return saveFile();
                }
                else if (result == DialogResult.No)
                {
                    // Nếu chọn No -> Không lưu, nhưng vẫn cho phép đi tiếp (hủy bỏ thay đổi)
                    return true;
                }
                else // DialogResult.Cancel
                {
                    // Nếu chọn Cancel -> Dừng mọi thao tác
                    return false;
                }
            }
            return true;// Nếu không có thay đổi thì cứ đi tiếp
        }

        private void ToggleFontStyle(FontStyle style)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newStyle;

                // Dùng toán tử XOR (^) để đảo trạng thái của style truyền vào
                // Ví dụ: Regular ^ Bold = Bold | Bold ^ Bold = Regular
                newStyle = currentFont.Style ^ style;

                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            }
        }
        private void updateFont(string font)
        {
            if (richTextBox1.SelectionFont != null)
            {
                richTextBox1.SelectionFont = new Font(font, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
            }
        }
        void updateFontSize(float size)
        {
            if (richTextBox1.SelectionFont != null)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, size, richTextBox1.SelectionFont.Style);
            }
        }
        private void openFile()
        {
            if (confirmSave() == false) return;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Rich Text Format|*.rtf|Text File|*.txt";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (openFile.FileName.EndsWith(".rtf"))
                        richTextBox1.LoadFile(openFile.FileName, RichTextBoxStreamType.RichText);
                    else
                        richTextBox1.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
                    currentFilePath = openFile.FileName;
                    richTextBox1.Modified = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đọc file: " + ex.Message);
                }
            }
            currentFilePath = openFile.FileName;
        }
        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();
            f.Font = richTextBox1.SelectionFont;

            if (f.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = f.Font;
            }
        }
        private bool saveFile()
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Rich Text Format|*.rtf"; // Chỉ định đuôi .rtf
                saveFileDialog.DefaultExt = "rtf"; // Mặc định đuôi file
                saveFileDialog.Title = "Lưu văn bản mới";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Lưu nội dung xuống đường dẫn người dùng chọn
                        richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);

                        // QUAN TRỌNG: Cập nhật đường dẫn vào biến toàn cục để lần sau biết là "đã lưu"
                        currentFilePath = saveFileDialog.FileName;
                        richTextBox1.Modified = false;
                        MessageBox.Show("Lưu văn bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi khi lưu file: " + ex.Message);
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            // TRƯỜNG HỢP 2: Văn bản cũ (Đã có đường dẫn từ lần Mở hoặc Lưu trước đó)
            else
            {
                try
                {
                    // Lưu đè trực tiếp xuống đường dẫn cũ, không hiện hộp thoại nữa
                    richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                    richTextBox1.Modified = false;
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi lưu file: " + ex.Message);
                    return false;
                }
            }
        }
        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetContent();
        }

        private void toolStrip_bold_btn_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Bold);
        }

        private void toolStrip_italic_btn_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Italic);
        }

        private void toolStrip_underline_btn_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Underline);
        }

        private void toolStrip_fontFamily_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateFont(toolStrip_fontFamily_cbb.SelectedItem.ToString());
        }

        private void toolStrip_fontSize_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateFontSize(float.Parse(toolStrip_fontSize_cbb.SelectedItem.ToString()));
        }

        private void toolStrip_new_btn_Click(object sender, EventArgs e)
        {
            resetContent();
        }

        private void lưuTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void toolStrip_save_btn_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!confirmSave())
            {
                e.Cancel = true;
            }
        }
    }
}
