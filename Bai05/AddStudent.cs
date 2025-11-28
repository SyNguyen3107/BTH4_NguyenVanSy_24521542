using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bai05
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }
        public string MSSV
        {
            get { return MSSV_tb.Text; }
        }

        // Lấy Tên sinh viên
        public string TenSV
        {
            get { return TenSV_tb.Text; }
        }

        // Lấy Khoa (Ví dụ từ ComboBox)
        public string Khoa
        {
            get { return Khoa_cbb.SelectedItem != null ? Khoa_cbb.SelectedItem.ToString() : ""; }
        }

        // Lấy Điểm (Ví dụ từ TextBox)
        public string Score
        {
            get { return DiemTB_tb.Text; }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MSSV) || string.IsNullOrWhiteSpace(TenSV) ||
                string.IsNullOrWhiteSpace(Khoa) || string.IsNullOrWhiteSpace(Score))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
