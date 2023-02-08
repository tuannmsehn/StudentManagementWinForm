namespace MyProject
{
    partial class FormXemDiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMaSV = new System.Windows.Forms.ComboBox();
            this.cboTenSV = new System.Windows.Forms.ComboBox();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.dgXemDiem = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgXemDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khoa";
            // 
            // cboMaSV
            // 
            this.cboMaSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaSV.FormattingEnabled = true;
            this.cboMaSV.Location = new System.Drawing.Point(87, 33);
            this.cboMaSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaSV.Name = "cboMaSV";
            this.cboMaSV.Size = new System.Drawing.Size(138, 28);
            this.cboMaSV.TabIndex = 3;
            this.cboMaSV.SelectedIndexChanged += new System.EventHandler(this.cboMaSV_SelectedIndexChanged);
            // 
            // cboTenSV
            // 
            this.cboTenSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenSV.FormattingEnabled = true;
            this.cboTenSV.Location = new System.Drawing.Point(87, 80);
            this.cboTenSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboTenSV.Name = "cboTenSV";
            this.cboTenSV.Size = new System.Drawing.Size(220, 28);
            this.cboTenSV.TabIndex = 4;
            this.cboTenSV.SelectedIndexChanged += new System.EventHandler(this.cboTenSV_SelectedIndexChanged);
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(89, 127);
            this.txtKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.ReadOnly = true;
            this.txtKhoa.Size = new System.Drawing.Size(218, 27);
            this.txtKhoa.TabIndex = 5;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(363, 32);
            this.btnView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(86, 31);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "Xem";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dgXemDiem
            // 
            this.dgXemDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgXemDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgXemDiem.Location = new System.Drawing.Point(23, 227);
            this.dgXemDiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgXemDiem.Name = "dgXemDiem";
            this.dgXemDiem.RowHeadersWidth = 51;
            this.dgXemDiem.RowTemplate.Height = 25;
            this.dgXemDiem.Size = new System.Drawing.Size(454, 253);
            this.dgXemDiem.TabIndex = 7;
            this.dgXemDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgXemDiem_CellClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(363, 108);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 31);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Sửa Điểm";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên môn";
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(343, 173);
            this.txtMark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(94, 27);
            this.txtMark.TabIndex = 10;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(89, 173);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.ReadOnly = true;
            this.txtSubject.Size = new System.Drawing.Size(201, 27);
            this.txtSubject.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Điểm";
            // 
            // FormXemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 496);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtMark);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgXemDiem);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.txtKhoa);
            this.Controls.Add(this.cboTenSV);
            this.Controls.Add(this.cboMaSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormXemDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormXemDiem";
            this.Load += new System.EventHandler(this.FormXemDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgXemDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMaSV;
        private System.Windows.Forms.ComboBox cboTenSV;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dgXemDiem;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label5;
    }
}