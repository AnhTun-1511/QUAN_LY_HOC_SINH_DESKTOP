namespace QuanLyHocSinh
{
    partial class FormQuanLyKhoaHoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_CapNhat = new System.Windows.Forms.Button();
            this.textBox_ThongTin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_GioHoc = new System.Windows.Forms.TextBox();
            this.textBox_TenKhoaHoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridView_KhoaHoc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.button_XoaThongTin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_XoaKhoaHoc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_IdKhoaHoc = new System.Windows.Forms.TextBox();
            this.textBox_TimKiem = new System.Windows.Forms.TextBox();
            this.button_TimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_KhoaHoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_CapNhat
            // 
            this.button_CapNhat.BackColor = System.Drawing.Color.Green;
            this.button_CapNhat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CapNhat.ForeColor = System.Drawing.Color.White;
            this.button_CapNhat.Location = new System.Drawing.Point(634, 331);
            this.button_CapNhat.Name = "button_CapNhat";
            this.button_CapNhat.Size = new System.Drawing.Size(112, 27);
            this.button_CapNhat.TabIndex = 63;
            this.button_CapNhat.Text = "Cập nhật";
            this.button_CapNhat.UseVisualStyleBackColor = false;
            this.button_CapNhat.Click += new System.EventHandler(this.button_CapNhat_Click);
            // 
            // textBox_ThongTin
            // 
            this.textBox_ThongTin.Location = new System.Drawing.Point(136, 397);
            this.textBox_ThongTin.Multiline = true;
            this.textBox_ThongTin.Name = "textBox_ThongTin";
            this.textBox_ThongTin.Size = new System.Drawing.Size(420, 84);
            this.textBox_ThongTin.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(11, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 61;
            this.label5.Text = "Thông tin chi tiết:";
            // 
            // textBox_GioHoc
            // 
            this.textBox_GioHoc.Location = new System.Drawing.Point(136, 367);
            this.textBox_GioHoc.Name = "textBox_GioHoc";
            this.textBox_GioHoc.Size = new System.Drawing.Size(217, 20);
            this.textBox_GioHoc.TabIndex = 60;
            this.textBox_GioHoc.TextChanged += new System.EventHandler(this.textBox_GioHoc_TextChanged);
            // 
            // textBox_TenKhoaHoc
            // 
            this.textBox_TenKhoaHoc.Location = new System.Drawing.Point(136, 331);
            this.textBox_TenKhoaHoc.Name = "textBox_TenKhoaHoc";
            this.textBox_TenKhoaHoc.Size = new System.Drawing.Size(296, 20);
            this.textBox_TenKhoaHoc.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(13, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 57;
            this.label3.Text = "Giờ học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(11, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Tên khoá học:";
            // 
            // DataGridView_KhoaHoc
            // 
            this.DataGridView_KhoaHoc.AllowUserToAddRows = false;
            this.DataGridView_KhoaHoc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_KhoaHoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_KhoaHoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_KhoaHoc.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridView_KhoaHoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_KhoaHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_KhoaHoc.ColumnHeadersHeight = 25;
            this.DataGridView_KhoaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_KhoaHoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_KhoaHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_KhoaHoc.Location = new System.Drawing.Point(0, 78);
            this.DataGridView_KhoaHoc.Name = "DataGridView_KhoaHoc";
            this.DataGridView_KhoaHoc.RowHeadersVisible = false;
            this.DataGridView_KhoaHoc.RowTemplate.Height = 40;
            this.DataGridView_KhoaHoc.Size = new System.Drawing.Size(824, 208);
            this.DataGridView_KhoaHoc.TabIndex = 56;
            this.DataGridView_KhoaHoc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_KhoaHoc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_KhoaHoc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_KhoaHoc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_KhoaHoc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_KhoaHoc.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridView_KhoaHoc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_KhoaHoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_KhoaHoc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_KhoaHoc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_KhoaHoc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_KhoaHoc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_KhoaHoc.ThemeStyle.HeaderStyle.Height = 25;
            this.DataGridView_KhoaHoc.ThemeStyle.ReadOnly = false;
            this.DataGridView_KhoaHoc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_KhoaHoc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_KhoaHoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_KhoaHoc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_KhoaHoc.ThemeStyle.RowsStyle.Height = 40;
            this.DataGridView_KhoaHoc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_KhoaHoc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_KhoaHoc.Click += new System.EventHandler(this.DataGridView_KhoaHoc_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(345, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Quản lý khoá học";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button_XoaThongTin
            // 
            this.button_XoaThongTin.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_XoaThongTin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_XoaThongTin.ForeColor = System.Drawing.Color.White;
            this.button_XoaThongTin.Location = new System.Drawing.Point(634, 371);
            this.button_XoaThongTin.Name = "button_XoaThongTin";
            this.button_XoaThongTin.Size = new System.Drawing.Size(112, 27);
            this.button_XoaThongTin.TabIndex = 65;
            this.button_XoaThongTin.Text = "Xoá thông tin";
            this.button_XoaThongTin.UseVisualStyleBackColor = false;
            this.button_XoaThongTin.Click += new System.EventHandler(this.button_XoaThongTin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 32);
            this.panel1.TabIndex = 64;
            // 
            // button_XoaKhoaHoc
            // 
            this.button_XoaKhoaHoc.BackColor = System.Drawing.Color.Red;
            this.button_XoaKhoaHoc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_XoaKhoaHoc.ForeColor = System.Drawing.Color.White;
            this.button_XoaKhoaHoc.Location = new System.Drawing.Point(634, 416);
            this.button_XoaKhoaHoc.Name = "button_XoaKhoaHoc";
            this.button_XoaKhoaHoc.Size = new System.Drawing.Size(112, 27);
            this.button_XoaKhoaHoc.TabIndex = 63;
            this.button_XoaKhoaHoc.Text = "Xoá khoá học";
            this.button_XoaKhoaHoc.UseVisualStyleBackColor = false;
            this.button_XoaKhoaHoc.Click += new System.EventHandler(this.button_XoaKhoaHoc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(13, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 66;
            this.label2.Text = "ID khoá học:";
            // 
            // textBox_IdKhoaHoc
            // 
            this.textBox_IdKhoaHoc.Location = new System.Drawing.Point(136, 301);
            this.textBox_IdKhoaHoc.Name = "textBox_IdKhoaHoc";
            this.textBox_IdKhoaHoc.Size = new System.Drawing.Size(136, 20);
            this.textBox_IdKhoaHoc.TabIndex = 67;
            // 
            // textBox_TimKiem
            // 
            this.textBox_TimKiem.Location = new System.Drawing.Point(573, 38);
            this.textBox_TimKiem.Name = "textBox_TimKiem";
            this.textBox_TimKiem.Size = new System.Drawing.Size(128, 20);
            this.textBox_TimKiem.TabIndex = 68;
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.BackColor = System.Drawing.Color.Green;
            this.button_TimKiem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TimKiem.ForeColor = System.Drawing.Color.White;
            this.button_TimKiem.Location = new System.Drawing.Point(707, 34);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(112, 27);
            this.button_TimKiem.TabIndex = 69;
            this.button_TimKiem.Text = "Tìm kiếm";
            this.button_TimKiem.UseVisualStyleBackColor = false;
            // 
            // FormQuanLyKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 491);
            this.Controls.Add(this.button_TimKiem);
            this.Controls.Add(this.textBox_TimKiem);
            this.Controls.Add(this.textBox_IdKhoaHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_XoaKhoaHoc);
            this.Controls.Add(this.button_CapNhat);
            this.Controls.Add(this.textBox_ThongTin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_GioHoc);
            this.Controls.Add(this.textBox_TenKhoaHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView_KhoaHoc);
            this.Controls.Add(this.button_XoaThongTin);
            this.Controls.Add(this.panel1);
            this.Name = "FormQuanLyKhoaHoc";
            this.Text = "FormQuanLyKhoaHoc";
            this.Load += new System.EventHandler(this.FormQuanLyKhoaHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_KhoaHoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_CapNhat;
        private System.Windows.Forms.TextBox textBox_ThongTin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_GioHoc;
        private System.Windows.Forms.TextBox textBox_TenKhoaHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_KhoaHoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_XoaThongTin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_XoaKhoaHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_IdKhoaHoc;
        private System.Windows.Forms.TextBox textBox_TimKiem;
        private System.Windows.Forms.Button button_TimKiem;
    }
}