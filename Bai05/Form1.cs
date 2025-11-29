using Bai05.Model;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form1 : Form
    {
        //lớp hỗ trợ thao tác với DB SQLite
        private DatabaseHelper _dbHelper;
        // Đây là danh sách gốc chứa TOÀN BỘ sinh viên dùng để khôi phục khi tìm kiếm
        private List<Student> _originalStudentList;
        public Form1()
        {
            InitializeComponent();
            _dbHelper = new DatabaseHelper();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataToListView();
        }
        // Hàm load dữ liệu từ DB lên ListView
        private void LoadDataToListView()
        {
            // Lấy dữ liệu từ DB
            _originalStudentList = _dbHelper.GetAllStudents();

            // Đẩy vào ListView 
            StudentAdapter(_originalStudentList);
        }
        private void StudentAdapter(List<Student> sourceList)
        {
            listView1.Items.Clear();
            int stt = 1;
            foreach (var s in sourceList)
            {
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(s.MSSV);
                item.SubItems.Add(s.TenSV);
                item.SubItems.Add(s.Khoa);
                item.SubItems.Add(s.DiemTB.ToString());

                listView1.Items.Add(item);
                stt++;
            }
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
                Student newStudent = new Student()
                {
                    MSSV = addStudent.MSSV,
                    TenSV = addStudent.TenSV,
                    Khoa = addStudent.Khoa,
                    DiemTB = float.Parse(addStudent.Score)
                };

                // Thêm sinh viên vào DB
                _dbHelper.AddStudent(newStudent);
                // Cập nhật lại danh sách gốc và load lại dữ liệu lên ListView
                _originalStudentList.Add(newStudent);
                LoadDataToListView();
                MessageBox.Show("Thêm sinh viên thành công!");
            }
        }

        private void searchByName_tb_TextChanged(object sender, EventArgs e)
        {
            string keyword = searchByName_tb.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                StudentAdapter(_originalStudentList);
            }
            else
            {
                // Lọc trên danh sách đã lấy từ DB
                var filteredList = _originalStudentList.Where(s =>
                    s.TenSV.ToLower().Contains(keyword)
                ).ToList();
                StudentAdapter(filteredList);
            }
        }
    }
}
