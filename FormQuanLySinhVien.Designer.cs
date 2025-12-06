namespace QuanLyHocSinh
{
    partial class FormQuanLySinhVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_sdt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_capnhat = new System.Windows.Forms.Button();
            this.button_xoasinhvien = new System.Windows.Forms.Button();
            this.button_taianh = new System.Windows.Forms.Button();
            this.textBox_diachi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton_nu = new System.Windows.Forms.RadioButton();
            this.radioButton_nam = new System.Windows.Forms.RadioButton();
            this.dateTimePicker_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.textBox_ten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridView_SinhVien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pictureBox_sinhvien = new System.Windows.Forms.PictureBox();
            this.button_xoathongtin = new System.Windows.Forms.Button();
            this.button_TimKiem = new System.Windows.Forms.Button();
            this.textBox_TimKiem = new System.Windows.Forms.TextBox();
            this.label_SinhVienId = new System.Windows.Forms.Label();
            this.textBox_SinhVienId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_SinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 32);
            this.panel1.TabIndex = 30;
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
            this.label7.Size = new System.Drawing.Size(163, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Quản lý sinh viên";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox_sdt
            // 
            this.textBox_sdt.Location = new System.Drawing.Point(87, 462);
            this.textBox_sdt.Name = "textBox_sdt";
            this.textBox_sdt.Size = new System.Drawing.Size(217, 20);
            this.textBox_sdt.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(13, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "SĐT:";
            // 
            // button_capnhat
            // 
            this.button_capnhat.BackColor = System.Drawing.Color.Green;
            this.button_capnhat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_capnhat.ForeColor = System.Drawing.Color.White;
            this.button_capnhat.Location = new System.Drawing.Point(580, 457);
            this.button_capnhat.Name = "button_capnhat";
            this.button_capnhat.Size = new System.Drawing.Size(112, 27);
            this.button_capnhat.TabIndex = 27;
            this.button_capnhat.Text = "Cập nhật";
            this.button_capnhat.UseVisualStyleBackColor = false;
            this.button_capnhat.Click += new System.EventHandler(this.button_capnhat_Click);
            // 
            // button_xoasinhvien
            // 
            this.button_xoasinhvien.BackColor = System.Drawing.Color.Red;
            this.button_xoasinhvien.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoasinhvien.ForeColor = System.Drawing.Color.White;
            this.button_xoasinhvien.Location = new System.Drawing.Point(700, 457);
            this.button_xoasinhvien.Name = "button_xoasinhvien";
            this.button_xoasinhvien.Size = new System.Drawing.Size(112, 27);
            this.button_xoasinhvien.TabIndex = 26;
            this.button_xoasinhvien.Text = "Xoá sinh viên";
            this.button_xoasinhvien.UseVisualStyleBackColor = false;
            this.button_xoasinhvien.Click += new System.EventHandler(this.button_xoasinhvien_Click);
            // 
            // button_taianh
            // 
            this.button_taianh.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_taianh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_taianh.ForeColor = System.Drawing.Color.White;
            this.button_taianh.Location = new System.Drawing.Point(673, 401);
            this.button_taianh.Name = "button_taianh";
            this.button_taianh.Size = new System.Drawing.Size(112, 27);
            this.button_taianh.TabIndex = 25;
            this.button_taianh.Text = "Tải ảnh";
            this.button_taianh.UseVisualStyleBackColor = false;
            this.button_taianh.Click += new System.EventHandler(this.button_taianh_Click);
            // 
            // textBox_diachi
            // 
            this.textBox_diachi.Location = new System.Drawing.Point(87, 365);
            this.textBox_diachi.Multiline = true;
            this.textBox_diachi.Name = "textBox_diachi";
            this.textBox_diachi.Size = new System.Drawing.Size(455, 77);
            this.textBox_diachi.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(13, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Địa chỉ:";
            // 
            // radioButton_nu
            // 
            this.radioButton_nu.AutoSize = true;
            this.radioButton_nu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_nu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.radioButton_nu.Location = new System.Drawing.Point(531, 328);
            this.radioButton_nu.Name = "radioButton_nu";
            this.radioButton_nu.Size = new System.Drawing.Size(43, 20);
            this.radioButton_nu.TabIndex = 21;
            this.radioButton_nu.TabStop = true;
            this.radioButton_nu.Text = "Nữ";
            this.radioButton_nu.UseVisualStyleBackColor = true;
            // 
            // radioButton_nam
            // 
            this.radioButton_nam.AutoSize = true;
            this.radioButton_nam.Checked = true;
            this.radioButton_nam.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_nam.ForeColor = System.Drawing.SystemColors.Highlight;
            this.radioButton_nam.Location = new System.Drawing.Point(469, 326);
            this.radioButton_nam.Name = "radioButton_nam";
            this.radioButton_nam.Size = new System.Drawing.Size(56, 20);
            this.radioButton_nam.TabIndex = 20;
            this.radioButton_nam.TabStop = true;
            this.radioButton_nam.Text = "Nam";
            this.radioButton_nam.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_ngaysinh
            // 
            this.dateTimePicker_ngaysinh.Location = new System.Drawing.Point(87, 328);
            this.dateTimePicker_ngaysinh.Name = "dateTimePicker_ngaysinh";
            this.dateTimePicker_ngaysinh.Size = new System.Drawing.Size(296, 20);
            this.dateTimePicker_ngaysinh.TabIndex = 19;
            // 
            // textBox_ten
            // 
            this.textBox_ten.Location = new System.Drawing.Point(87, 291);
            this.textBox_ten.Name = "textBox_ten";
            this.textBox_ten.Size = new System.Drawing.Size(217, 20);
            this.textBox_ten.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(397, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(13, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nhập tên:";
            // 
            // textBox_ho
            // 
            this.textBox_ho.Location = new System.Drawing.Point(87, 265);
            this.textBox_ho.Name = "textBox_ho";
            this.textBox_ho.Size = new System.Drawing.Size(296, 20);
            this.textBox_ho.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(12, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ngày sinh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(13, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nhập họ:";
            // 
            // DataGridView_SinhVien
            // 
            this.DataGridView_SinhVien.AllowUserToAddRows = false;
            this.DataGridView_SinhVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridView_SinhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView_SinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_SinhVien.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridView_SinhVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_SinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView_SinhVien.ColumnHeadersHeight = 25;
            this.DataGridView_SinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_SinhVien.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView_SinhVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_SinhVien.Location = new System.Drawing.Point(0, 74);
            this.DataGridView_SinhVien.Name = "DataGridView_SinhVien";
            this.DataGridView_SinhVien.RowHeadersVisible = false;
            this.DataGridView_SinhVien.RowTemplate.Height = 40;
            this.DataGridView_SinhVien.Size = new System.Drawing.Size(824, 165);
            this.DataGridView_SinhVien.TabIndex = 12;
            this.DataGridView_SinhVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_SinhVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_SinhVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_SinhVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_SinhVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_SinhVien.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridView_SinhVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_SinhVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_SinhVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_SinhVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_SinhVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_SinhVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_SinhVien.ThemeStyle.HeaderStyle.Height = 25;
            this.DataGridView_SinhVien.ThemeStyle.ReadOnly = false;
            this.DataGridView_SinhVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_SinhVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_SinhVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_SinhVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_SinhVien.ThemeStyle.RowsStyle.Height = 40;
            this.DataGridView_SinhVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_SinhVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_SinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_SinhVien_CellContentClick);
            this.DataGridView_SinhVien.Click += new System.EventHandler(this.DataGridView_SinhVien_Click);
            // 
            // pictureBox_sinhvien
            // 
            this.pictureBox_sinhvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_sinhvien.Location = new System.Drawing.Point(673, 258);
            this.pictureBox_sinhvien.Name = "pictureBox_sinhvien";
            this.pictureBox_sinhvien.Size = new System.Drawing.Size(112, 124);
            this.pictureBox_sinhvien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_sinhvien.TabIndex = 24;
            this.pictureBox_sinhvien.TabStop = false;
            // 
            // button_xoathongtin
            // 
            this.button_xoathongtin.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_xoathongtin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoathongtin.ForeColor = System.Drawing.Color.White;
            this.button_xoathongtin.Location = new System.Drawing.Point(462, 457);
            this.button_xoathongtin.Name = "button_xoathongtin";
            this.button_xoathongtin.Size = new System.Drawing.Size(112, 27);
            this.button_xoathongtin.TabIndex = 31;
            this.button_xoathongtin.Text = "Xoá thông tin";
            this.button_xoathongtin.UseVisualStyleBackColor = false;
            this.button_xoathongtin.Click += new System.EventHandler(this.button_xoathongtin_Click);
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_TimKiem.BackColor = System.Drawing.Color.Gray;
            this.button_TimKiem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TimKiem.ForeColor = System.Drawing.Color.White;
            this.button_TimKiem.Location = new System.Drawing.Point(700, 41);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(112, 27);
            this.button_TimKiem.TabIndex = 32;
            this.button_TimKiem.Text = "Tìm kiếm";
            this.button_TimKiem.UseVisualStyleBackColor = false;
            this.button_TimKiem.Click += new System.EventHandler(this.button_TimKiem_Click);
            // 
            // textBox_TimKiem
            // 
            this.textBox_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_TimKiem.Location = new System.Drawing.Point(477, 45);
            this.textBox_TimKiem.Name = "textBox_TimKiem";
            this.textBox_TimKiem.Size = new System.Drawing.Size(217, 20);
            this.textBox_TimKiem.TabIndex = 33;
            this.textBox_TimKiem.TextChanged += new System.EventHandler(this.textBox_TimKiem_TextChanged);
            // 
            // label_SinhVienId
            // 
            this.label_SinhVienId.AutoSize = true;
            this.label_SinhVienId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SinhVienId.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_SinhVienId.Location = new System.Drawing.Point(403, 266);
            this.label_SinhVienId.Name = "label_SinhVienId";
            this.label_SinhVienId.Size = new System.Drawing.Size(64, 16);
            this.label_SinhVienId.TabIndex = 34;
            this.label_SinhVienId.Text = "Nhập id:";
            // 
            // textBox_SinhVienId
            // 
            this.textBox_SinhVienId.Location = new System.Drawing.Point(477, 265);
            this.textBox_SinhVienId.Name = "textBox_SinhVienId";
            this.textBox_SinhVienId.Size = new System.Drawing.Size(123, 20);
            this.textBox_SinhVienId.TabIndex = 35;
            // 
            // FormQuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 491);
            this.Controls.Add(this.textBox_SinhVienId);
            this.Controls.Add(this.label_SinhVienId);
            this.Controls.Add(this.textBox_TimKiem);
            this.Controls.Add(this.button_TimKiem);
            this.Controls.Add(this.button_xoathongtin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_sdt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_capnhat);
            this.Controls.Add(this.button_xoasinhvien);
            this.Controls.Add(this.button_taianh);
            this.Controls.Add(this.pictureBox_sinhvien);
            this.Controls.Add(this.textBox_diachi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton_nu);
            this.Controls.Add(this.radioButton_nam);
            this.Controls.Add(this.dateTimePicker_ngaysinh);
            this.Controls.Add(this.textBox_ten);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView_SinhVien);
            this.Name = "FormQuanLySinhVien";
            this.Text = "FormQuanLySinhVien";
            this.Load += new System.EventHandler(this.FormQuanLySinhVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_SinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sinhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_sdt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_capnhat;
        private System.Windows.Forms.Button button_xoasinhvien;
        private System.Windows.Forms.Button button_taianh;
        private System.Windows.Forms.PictureBox pictureBox_sinhvien;
        private System.Windows.Forms.TextBox textBox_diachi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton_nu;
        private System.Windows.Forms.RadioButton radioButton_nam;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngaysinh;
        private System.Windows.Forms.TextBox textBox_ten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_SinhVien;
        private System.Windows.Forms.Button button_xoathongtin;
        private System.Windows.Forms.Button button_TimKiem;
        private System.Windows.Forms.TextBox textBox_TimKiem;
        private System.Windows.Forms.Label label_SinhVienId;
        private System.Windows.Forms.TextBox textBox_SinhVienId;
    }
}