namespace MyProject
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFaculty = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInputMark = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmViewMark = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStatisticFaculty = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tsmSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmStudent,
            this.tsmFaculty,
            this.tsmSubject,
            this.tsmInputMark,
            this.tsmViewMark,
            this.tsmStatisticFaculty,
            this.thoátToolStripMenuItem,
            this.tsmExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 30);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmStudent
            // 
            this.tsmStudent.Image = global::MyProject.Properties.Resources.addStudent;
            this.tsmStudent.Name = "tsmStudent";
            this.tsmStudent.Size = new System.Drawing.Size(104, 24);
            this.tsmStudent.Text = "Sinh Viên";
            this.tsmStudent.Click += new System.EventHandler(this.tsmStudent_Click);
            // 
            // tsmFaculty
            // 
            this.tsmFaculty.Image = global::MyProject.Properties.Resources.Khoa;
            this.tsmFaculty.Name = "tsmFaculty";
            this.tsmFaculty.Size = new System.Drawing.Size(77, 24);
            this.tsmFaculty.Text = "Khoa";
            this.tsmFaculty.Click += new System.EventHandler(this.tsmFaculty_Click);
            // 
            // tsmSubject
            // 
            this.tsmSubject.Image = global::MyProject.Properties.Resources.subject;
            this.tsmSubject.Name = "tsmSubject";
            this.tsmSubject.Size = new System.Drawing.Size(104, 24);
            this.tsmSubject.Text = "Môn Học";
            this.tsmSubject.Click += new System.EventHandler(this.tsmSubject_Click);
            // 
            // tsmInputMark
            // 
            this.tsmInputMark.Image = global::MyProject.Properties.Resources.inputmark;
            this.tsmInputMark.Name = "tsmInputMark";
            this.tsmInputMark.Size = new System.Drawing.Size(119, 24);
            this.tsmInputMark.Text = "Nhập Điểm";
            this.tsmInputMark.Click += new System.EventHandler(this.tsmInputMark_Click);
            // 
            // tsmViewMark
            // 
            this.tsmViewMark.Image = global::MyProject.Properties.Resources.viewmark;
            this.tsmViewMark.Name = "tsmViewMark";
            this.tsmViewMark.Size = new System.Drawing.Size(113, 24);
            this.tsmViewMark.Text = "Xem Điểm";
            this.tsmViewMark.Click += new System.EventHandler(this.tsmViewMark_Click);
            // 
            // tsmStatisticFaculty
            // 
            this.tsmStatisticFaculty.Image = global::MyProject.Properties.Resources.thongke;
            this.tsmStatisticFaculty.Name = "tsmStatisticFaculty";
            this.tsmStatisticFaculty.Size = new System.Drawing.Size(144, 24);
            this.tsmStatisticFaculty.Text = "Thống Kê Khoa";
            this.tsmStatisticFaculty.Click += new System.EventHandler(this.tsmStatisticFaculty_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // tsmExit
            // 
            this.tsmExit.Image = global::MyProject.Properties.Resources.exit;
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(81, 24);
            this.tsmExit.Text = "Thoát";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSystem,
            this.tsmFunction,
            this.tsmHelp});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip2.Size = new System.Drawing.Size(800, 30);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tsmSystem
            // 
            this.tsmSystem.Name = "tsmSystem";
            this.tsmSystem.Size = new System.Drawing.Size(85, 24);
            this.tsmSystem.Text = "Hệ thống";
            this.tsmSystem.Click += new System.EventHandler(this.tsmSystem_Click);
            // 
            // tsmFunction
            // 
            this.tsmFunction.Name = "tsmFunction";
            this.tsmFunction.Size = new System.Drawing.Size(96, 24);
            this.tsmFunction.Text = "Chức Năng";
            // 
            // tsmHelp
            // 
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(68, 24);
            this.tsmHelp.Text = "Hỗ Trợ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(214, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chương Trình Quản Lý Sinh Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(53, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(702, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Người dùng chọn các chức năng trên menu để sử dụng các tính năng ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::MyProject.Properties.Resources.fpt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmFaculty;
        private System.Windows.Forms.ToolStripMenuItem tsmStudent;
        private System.Windows.Forms.ToolStripMenuItem tsmSubject;
        private System.Windows.Forms.ToolStripMenuItem tsmInputMark;
        private System.Windows.Forms.ToolStripMenuItem tsmViewMark;
        private System.Windows.Forms.ToolStripMenuItem tsmStatisticFaculty;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tsmSystem;
        private System.Windows.Forms.ToolStripMenuItem tsmFunction;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
