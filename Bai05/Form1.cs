namespace Bai05
{
    public partial class Form1 : Form
    {
        // Đây là danh sách gốc chứa TOÀN BỘ sinh viên dùng để khôi phục khi tìm kiếm
        List<ListViewItem> _originalItems = new List<ListViewItem>();
        public Form1()
        {
            InitializeComponent();
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAddStudentForm();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            openAddStudentForm();
        }
        private void openAddStudentForm()
        {
            var addStudent = new AddStudent();
            addStudent.StartPosition = FormStartPosition.CenterParent;
            if (addStudent.ShowDialog() == DialogResult.OK)
            {
                // Lấy thông tin sinh viên từ form AddStudent
                string mssv = addStudent.MSSV;
                string tenSv = addStudent.TenSV;
                string khoa = addStudent.Khoa;
                string diem = addStudent.Score;
                // Tạo một ListViewItem mới và thêm vào ListView
                var item = new ListViewItem((listView1.Items.Count + 1).ToString());
                item.SubItems.Add(mssv);
                item.SubItems.Add(tenSv);
                item.SubItems.Add(khoa);
                item.SubItems.Add(diem);
                listView1.Items.Add(item);
                _originalItems.Add((ListViewItem)item.Clone());
            }
        }

        private void searchByName_tb_TextChanged(object sender, EventArgs e)
        {
            string keyword = searchByName_tb.Text.Trim().ToLower();
            //Tạm dừng vẽ ListView để tránh bị nhấp nháy khi dữ liệu nhiều
            listView1.BeginUpdate();

            listView1.Items.Clear();
            //Khi ô tìm kiếm trống, hiển thị lại toàn bộ danh sách
            if (string.IsNullOrEmpty(keyword))
            {
                listView1.Items.AddRange(_originalItems.ToArray());
            }
            else
            {
                foreach (var item in _originalItems)
                {
                    //So sánh tên sinh viên với từ khóa tìm kiếm
                    if (item.SubItems[2].Text.ToLower().Contains(keyword))
                    {
                        listView1.Items.Add((ListViewItem)item.Clone());
                    }
                }
            }
            listView1.EndUpdate();
        }
    }
}
