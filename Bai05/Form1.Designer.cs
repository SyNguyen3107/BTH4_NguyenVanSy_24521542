namespace Bai05
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            thêmMớiToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            Add_btn = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            searchByName_tb = new ToolStripTextBox();
            listView1 = new ListView();
            STT_col = new ColumnHeader();
            MSSV_col = new ColumnHeader();
            TenSV_col = new ColumnHeader();
            Khoa_col = new ColumnHeader();
            DiemTB_col = new ColumnHeader();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chứcNăngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(778, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmMớiToolStripMenuItem, thoátToolStripMenuItem });
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(116, 29);
            chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // thêmMớiToolStripMenuItem
            // 
            thêmMớiToolStripMenuItem.Name = "thêmMớiToolStripMenuItem";
            thêmMớiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            thêmMớiToolStripMenuItem.Size = new Size(270, 34);
            thêmMớiToolStripMenuItem.Text = "Thêm mới";
            thêmMớiToolStripMenuItem.Click += thêmMớiToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(270, 34);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(60, 60);
            toolStrip1.Items.AddRange(new ToolStripItem[] { Add_btn, toolStripLabel1, searchByName_tb });
            toolStrip1.Location = new Point(0, 33);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(778, 69);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // Add_btn
            // 
            Add_btn.Image = (Image)resources.GetObject("Add_btn.Image");
            Add_btn.ImageTransparentColor = Color.Magenta;
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(156, 64);
            Add_btn.Text = "Thêm Mới";
            Add_btn.Click += Add_btn_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Margin = new Padding(100, 2, 0, 3);
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(160, 64);
            toolStripLabel1.Text = "Tìm Kiếm Theo Tên";
            // 
            // searchByName_tb
            // 
            searchByName_tb.AutoSize = false;
            searchByName_tb.Name = "searchByName_tb";
            searchByName_tb.Size = new Size(310, 69);
            searchByName_tb.TextChanged += searchByName_tb_TextChanged;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { STT_col, MSSV_col, TenSV_col, Khoa_col, DiemTB_col });
            listView1.Dock = DockStyle.Fill;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(0, 102);
            listView1.Name = "listView1";
            listView1.Size = new Size(778, 442);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // STT_col
            // 
            STT_col.Text = "Số TT";
            STT_col.Width = 70;
            // 
            // MSSV_col
            // 
            MSSV_col.Text = "Mã Số SV";
            MSSV_col.Width = 120;
            // 
            // TenSV_col
            // 
            TenSV_col.Text = "Tên Sinh Viên";
            TenSV_col.Width = 250;
            // 
            // Khoa_col
            // 
            Khoa_col.Text = "Khoa";
            Khoa_col.Width = 220;
            // 
            // DiemTB_col
            // 
            DiemTB_col.Text = "Điểm TB";
            DiemTB_col.Width = 120;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 544);
            Controls.Add(listView1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Quản Lý Sinh Viên";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem thêmMớiToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton Add_btn;
        private ToolStripLabel toolStripLabel1;
        private ListView listView1;
        private ColumnHeader STT_col;
        private ColumnHeader MSSV_col;
        private ColumnHeader TenSV_col;
        private ColumnHeader Khoa_col;
        private ColumnHeader DiemTB_col;
        private ToolStripTextBox searchByName_tb;
    }
}
