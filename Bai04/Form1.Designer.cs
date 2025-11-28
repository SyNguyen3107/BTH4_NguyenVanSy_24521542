namespace Bai04
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
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            tạoVănBảnMớiToolStripMenuItem = new ToolStripMenuItem();
            mởTậpTinToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            lưuNộiDungVănBảnToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            địnhDạngToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStrip_new_btn = new ToolStripButton();
            toolStrip_save_btn = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStrip_fontFamily_cbb = new ToolStripComboBox();
            toolStrip_fontSize_cbb = new ToolStripComboBox();
            toolStrip_bold_btn = new ToolStripButton();
            toolStrip_italic_btn = new ToolStripButton();
            toolStrip_underline_btn = new ToolStripButton();
            richTextBox1 = new RichTextBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, địnhDạngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tạoVănBảnMớiToolStripMenuItem, mởTậpTinToolStripMenuItem, toolStripSeparator1, lưuNộiDungVănBảnToolStripMenuItem, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(103, 29);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // tạoVănBảnMớiToolStripMenuItem
            // 
            tạoVănBảnMớiToolStripMenuItem.Image = Properties.Resources.file;
            tạoVănBảnMớiToolStripMenuItem.Name = "tạoVănBảnMớiToolStripMenuItem";
            tạoVănBảnMớiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            tạoVănBảnMớiToolStripMenuItem.Size = new Size(349, 34);
            tạoVănBảnMớiToolStripMenuItem.Text = "Tạo văn bản mới";
            tạoVănBảnMớiToolStripMenuItem.Click += tạoVănBảnMớiToolStripMenuItem_Click;
            // 
            // mởTậpTinToolStripMenuItem
            // 
            mởTậpTinToolStripMenuItem.Image = Properties.Resources.folder_open;
            mởTậpTinToolStripMenuItem.Name = "mởTậpTinToolStripMenuItem";
            mởTậpTinToolStripMenuItem.Size = new Size(349, 34);
            mởTậpTinToolStripMenuItem.Text = "Mở tập tin";
            mởTậpTinToolStripMenuItem.Click += mởTậpTinToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(346, 6);
            // 
            // lưuNộiDungVănBảnToolStripMenuItem
            // 
            lưuNộiDungVănBảnToolStripMenuItem.Image = Properties.Resources.diskette;
            lưuNộiDungVănBảnToolStripMenuItem.Name = "lưuNộiDungVănBảnToolStripMenuItem";
            lưuNộiDungVănBảnToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            lưuNộiDungVănBảnToolStripMenuItem.Size = new Size(349, 34);
            lưuNộiDungVănBảnToolStripMenuItem.Text = "Lưu nội dung văn bản";
            lưuNộiDungVănBảnToolStripMenuItem.Click += lưuNộiDungVănBảnToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(349, 34);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // địnhDạngToolStripMenuItem
            // 
            địnhDạngToolStripMenuItem.Name = "địnhDạngToolStripMenuItem";
            địnhDạngToolStripMenuItem.Size = new Size(111, 29);
            địnhDạngToolStripMenuItem.Text = "Định dạng";
            địnhDạngToolStripMenuItem.Click += địnhDạngToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStrip_new_btn, toolStrip_save_btn, toolStripSeparator2, toolStrip_fontFamily_cbb, toolStrip_fontSize_cbb, toolStrip_bold_btn, toolStrip_italic_btn, toolStrip_underline_btn });
            toolStrip1.Location = new Point(0, 33);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 33);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip_new_btn
            // 
            toolStrip_new_btn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStrip_new_btn.Image = Properties.Resources.file;
            toolStrip_new_btn.ImageTransparentColor = Color.Magenta;
            toolStrip_new_btn.Name = "toolStrip_new_btn";
            toolStrip_new_btn.Size = new Size(34, 28);
            toolStrip_new_btn.Text = "toolStripButton1";
            toolStrip_new_btn.Click += toolStrip_new_btn_Click;
            // 
            // toolStrip_save_btn
            // 
            toolStrip_save_btn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStrip_save_btn.Image = Properties.Resources.diskette;
            toolStrip_save_btn.ImageTransparentColor = Color.Magenta;
            toolStrip_save_btn.Name = "toolStrip_save_btn";
            toolStrip_save_btn.Size = new Size(34, 28);
            toolStrip_save_btn.Text = "toolStripButton2";
            toolStrip_save_btn.Click += toolStrip_save_btn_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 33);
            // 
            // toolStrip_fontFamily_cbb
            // 
            toolStrip_fontFamily_cbb.Name = "toolStrip_fontFamily_cbb";
            toolStrip_fontFamily_cbb.Size = new Size(220, 33);
            toolStrip_fontFamily_cbb.SelectedIndexChanged += toolStrip_fontFamily_cbb_SelectedIndexChanged;
            // 
            // toolStrip_fontSize_cbb
            // 
            toolStrip_fontSize_cbb.Name = "toolStrip_fontSize_cbb";
            toolStrip_fontSize_cbb.Size = new Size(121, 33);
            toolStrip_fontSize_cbb.SelectedIndexChanged += toolStrip_fontSize_cbb_SelectedIndexChanged;
            // 
            // toolStrip_bold_btn
            // 
            toolStrip_bold_btn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStrip_bold_btn.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStrip_bold_btn.Image = (Image)resources.GetObject("toolStrip_bold_btn.Image");
            toolStrip_bold_btn.ImageTransparentColor = Color.Magenta;
            toolStrip_bold_btn.Name = "toolStrip_bold_btn";
            toolStrip_bold_btn.Size = new Size(34, 28);
            toolStrip_bold_btn.Text = "B";
            toolStrip_bold_btn.Click += toolStrip_bold_btn_Click;
            // 
            // toolStrip_italic_btn
            // 
            toolStrip_italic_btn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStrip_italic_btn.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            toolStrip_italic_btn.Image = (Image)resources.GetObject("toolStrip_italic_btn.Image");
            toolStrip_italic_btn.ImageTransparentColor = Color.Magenta;
            toolStrip_italic_btn.Name = "toolStrip_italic_btn";
            toolStrip_italic_btn.Size = new Size(34, 28);
            toolStrip_italic_btn.Text = "I";
            toolStrip_italic_btn.Click += toolStrip_italic_btn_Click;
            // 
            // toolStrip_underline_btn
            // 
            toolStrip_underline_btn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStrip_underline_btn.Font = new Font("Times New Roman", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            toolStrip_underline_btn.Image = (Image)resources.GetObject("toolStrip_underline_btn.Image");
            toolStrip_underline_btn.ImageTransparentColor = Color.Magenta;
            toolStrip_underline_btn.Name = "toolStrip_underline_btn";
            toolStrip_underline_btn.Size = new Size(34, 28);
            toolStrip_underline_btn.Text = "U";
            toolStrip_underline_btn.Click += toolStrip_underline_btn_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 66);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 384);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Soạn thảo văn bản";
            FormClosing += Form1_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem tạoVănBảnMớiToolStripMenuItem;
        private ToolStripMenuItem mởTậpTinToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem lưuNộiDungVănBảnToolStripMenuItem;
        private ToolStripMenuItem địnhDạngToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStrip_new_btn;
        private ToolStripButton toolStrip_save_btn;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripComboBox toolStrip_fontFamily_cbb;
        private ToolStripComboBox toolStrip_fontSize_cbb;
        private ToolStripButton toolStrip_bold_btn;
        private ToolStripButton toolStrip_italic_btn;
        private ToolStripButton toolStrip_underline_btn;
        private RichTextBox richTextBox1;
    }
}
