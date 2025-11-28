namespace Bai06
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            copy_btn = new Button();
            opendest_btn = new Button();
            opensrc_btn = new Button();
            dest_tb = new TextBox();
            label2 = new Label();
            source_tb = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            progressBar1 = new ProgressBar();
            statusStrip1 = new StatusStrip();
            status_lb = new ToolStripStatusLabel();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(copy_btn);
            groupBox1.Controls.Add(opendest_btn);
            groupBox1.Controls.Add(opensrc_btn);
            groupBox1.Controls.Add(dest_tb);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(source_tb);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(49, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(869, 253);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sao chép tập tin";
            // 
            // copy_btn
            // 
            copy_btn.BackColor = SystemColors.ScrollBar;
            copy_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            copy_btn.ForeColor = Color.Black;
            copy_btn.Location = new Point(374, 190);
            copy_btn.Name = "copy_btn";
            copy_btn.Size = new Size(194, 46);
            copy_btn.TabIndex = 3;
            copy_btn.Text = "Sao Chép";
            copy_btn.UseVisualStyleBackColor = false;
            copy_btn.Click += copy_btn_Click;
            // 
            // opendest_btn
            // 
            opendest_btn.BackColor = SystemColors.ScrollBar;
            opendest_btn.Location = new Point(786, 126);
            opendest_btn.Name = "opendest_btn";
            opendest_btn.Size = new Size(59, 34);
            opendest_btn.TabIndex = 2;
            opendest_btn.Text = "...";
            opendest_btn.UseVisualStyleBackColor = false;
            opendest_btn.Click += opendest_btn_Click;
            // 
            // opensrc_btn
            // 
            opensrc_btn.BackColor = SystemColors.ScrollBar;
            opensrc_btn.Location = new Point(786, 55);
            opensrc_btn.Name = "opensrc_btn";
            opensrc_btn.Size = new Size(59, 34);
            opensrc_btn.TabIndex = 2;
            opensrc_btn.Text = "...";
            opensrc_btn.UseVisualStyleBackColor = false;
            opensrc_btn.Click += opensrc_btn_Click;
            // 
            // dest_tb
            // 
            dest_tb.Location = new Point(321, 126);
            dest_tb.Name = "dest_tb";
            dest_tb.Size = new Size(459, 34);
            dest_tb.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(29, 126);
            label2.Name = "label2";
            label2.Size = new Size(238, 28);
            label2.TabIndex = 0;
            label2.Text = "Đường Dẫn Thư Mục Đích";
            // 
            // source_tb
            // 
            source_tb.Location = new Point(321, 55);
            source_tb.Name = "source_tb";
            source_tb.Size = new Size(459, 34);
            source_tb.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(29, 55);
            label1.Name = "label1";
            label1.Size = new Size(260, 28);
            label1.TabIndex = 0;
            label1.Text = "Đường Dẫn Thư Mục Nguồn";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(progressBar1);
            groupBox2.Font = new Font("Segoe UI", 10F);
            groupBox2.ForeColor = Color.Blue;
            groupBox2.Location = new Point(49, 316);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(869, 123);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tiến trình sao chép";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(45, 55);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(767, 34);
            progressBar1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { status_lb });
            statusStrip1.Location = new Point(0, 462);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(978, 32);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // status_lb
            // 
            status_lb.Name = "status_lb";
            status_lb.Size = new Size(140, 25);
            status_lb.Text = "Đang sao chép: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 494);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Sao chép tập tin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Button opensrc_btn;
        private TextBox source_tb;
        private Button opendest_btn;
        private TextBox dest_tb;
        private Label label2;
        private Button copy_btn;
        private ProgressBar progressBar1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel status_lb;
        private ToolTip toolTip1;
    }
}
