namespace Bai05
{
    partial class AddStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MSSV_tb = new TextBox();
            MSSV_lb = new Label();
            TenSV_tb = new TextBox();
            TenSV_lb = new Label();
            DiemTB_tb = new TextBox();
            DiemTB_lb = new Label();
            label1 = new Label();
            Khoa_cbb = new ComboBox();
            Add_btn = new Button();
            Exit_btn = new Button();
            SuspendLayout();
            // 
            // MSSV_tb
            // 
            MSSV_tb.Location = new Point(225, 51);
            MSSV_tb.Name = "MSSV_tb";
            MSSV_tb.Size = new Size(311, 31);
            MSSV_tb.TabIndex = 0;
            // 
            // MSSV_lb
            // 
            MSSV_lb.AutoSize = true;
            MSSV_lb.Location = new Point(58, 51);
            MSSV_lb.Name = "MSSV_lb";
            MSSV_lb.Size = new Size(141, 25);
            MSSV_lb.TabIndex = 1;
            MSSV_lb.Text = "Mã Số Sinh Viên";
            // 
            // TenSV_tb
            // 
            TenSV_tb.Location = new Point(225, 119);
            TenSV_tb.Name = "TenSV_tb";
            TenSV_tb.Size = new Size(455, 31);
            TenSV_tb.TabIndex = 1;
            // 
            // TenSV_lb
            // 
            TenSV_lb.AutoSize = true;
            TenSV_lb.Location = new Point(58, 119);
            TenSV_lb.Name = "TenSV_lb";
            TenSV_lb.Size = new Size(116, 25);
            TenSV_lb.TabIndex = 1;
            TenSV_lb.Text = "Tên Sinh Viên";
            // 
            // DiemTB_tb
            // 
            DiemTB_tb.Location = new Point(225, 263);
            DiemTB_tb.Name = "DiemTB_tb";
            DiemTB_tb.Size = new Size(149, 31);
            DiemTB_tb.TabIndex = 3;
            // 
            // DiemTB_lb
            // 
            DiemTB_lb.AutoSize = true;
            DiemTB_lb.Location = new Point(58, 263);
            DiemTB_lb.Name = "DiemTB_lb";
            DiemTB_lb.Size = new Size(78, 25);
            DiemTB_lb.TabIndex = 1;
            DiemTB_lb.Text = "Điểm TB";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 191);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 1;
            label1.Text = "Khoa";
            // 
            // Khoa_cbb
            // 
            Khoa_cbb.AutoCompleteMode = AutoCompleteMode.Suggest;
            Khoa_cbb.AutoCompleteSource = AutoCompleteSource.ListItems;
            Khoa_cbb.FormattingEnabled = true;
            Khoa_cbb.Items.AddRange(new object[] { "Khoa học Máy tính", "Kỹ thuật Máy tính", "Công nghệ Phần mềm", "Hệ thống Thông tin", "Mạng máy tính và Truyền thông dữ liệu", "Khoa học và Kỹ thuật Thông tin " });
            Khoa_cbb.Location = new Point(225, 191);
            Khoa_cbb.Name = "Khoa_cbb";
            Khoa_cbb.Size = new Size(455, 33);
            Khoa_cbb.TabIndex = 2;
            // 
            // Add_btn
            // 
            Add_btn.BackColor = Color.LimeGreen;
            Add_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add_btn.Location = new Point(385, 338);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(151, 40);
            Add_btn.TabIndex = 4;
            Add_btn.Text = "Thêm Mới";
            Add_btn.UseVisualStyleBackColor = false;
            Add_btn.Click += Add_btn_Click;
            // 
            // Exit_btn
            // 
            Exit_btn.BackColor = Color.Red;
            Exit_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit_btn.Location = new Point(555, 338);
            Exit_btn.Name = "Exit_btn";
            Exit_btn.Size = new Size(151, 40);
            Exit_btn.TabIndex = 5;
            Exit_btn.Text = "Thoát";
            Exit_btn.UseVisualStyleBackColor = false;
            Exit_btn.Click += Exit_btn_Click;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 444);
            Controls.Add(Exit_btn);
            Controls.Add(Add_btn);
            Controls.Add(Khoa_cbb);
            Controls.Add(label1);
            Controls.Add(DiemTB_lb);
            Controls.Add(TenSV_lb);
            Controls.Add(MSSV_lb);
            Controls.Add(DiemTB_tb);
            Controls.Add(TenSV_tb);
            Controls.Add(MSSV_tb);
            Name = "AddStudent";
            Text = "Thêm Sinh Viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MSSV_tb;
        private Label MSSV_lb;
        private TextBox TenSV_tb;
        private Label TenSV_lb;
        private TextBox DiemTB_tb;
        private Label DiemTB_lb;
        private Label label1;
        private ComboBox Khoa_cbb;
        private Button Add_btn;
        private Button Exit_btn;
    }
}