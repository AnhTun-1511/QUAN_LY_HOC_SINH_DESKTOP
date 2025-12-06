namespace QuanLyHocSinh
{
    partial class FormSinhVienIn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button_in = new System.Windows.Forms.Button();
            this.radioButton_nu = new System.Windows.Forms.RadioButton();
            this.radioButton_nam = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.DataGridView_SinhVien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ComboBox_ChonLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_gioitinhall = new System.Windows.Forms.RadioButton();
            this.button_tim = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_SinhVien)).BeginInit();
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
            this.panel1.TabIndex = 52;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(363, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "In sinh viên";
            // 
            // button_in
            // 
            this.button_in.BackColor = System.Drawing.Color.Green;
            this.button_in.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_in.ForeColor = System.Drawing.Color.White;
            this.button_in.Location = new System.Drawing.Point(719, 452);
            this.button_in.Name = "button_in";
            this.button_in.Size = new System.Drawing.Size(93, 27);
            this.button_in.TabIndex = 51;
            this.button_in.Text = "In";
            this.button_in.UseVisualStyleBackColor = false;
            this.button_in.Click += new System.EventHandler(this.button_in_Click);
            // 
            // radioButton_nu
            // 
            this.radioButton_nu.AutoSize = true;
            this.radioButton_nu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_nu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.radioButton_nu.Location = new System.Drawing.Point(174, 450);
            this.radioButton_nu.Name = "radioButton_nu";
            this.radioButton_nu.Size = new System.Drawing.Size(43, 20);
            this.radioButton_nu.TabIndex = 45;
            this.radioButton_nu.TabStop = true;
            this.radioButton_nu.Text = "Nữ";
            this.radioButton_nu.UseVisualStyleBackColor = true;
            this.radioButton_nu.CheckedChanged += new System.EventHandler(this.radioButton_nu_CheckedChanged);
            // 
            // radioButton_nam
            // 
            this.radioButton_nam.AutoSize = true;
            this.radioButton_nam.Checked = true;
            this.radioButton_nam.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_nam.ForeColor = System.Drawing.SystemColors.Highlight;
            this.radioButton_nam.Location = new System.Drawing.Point(101, 450);
            this.radioButton_nam.Name = "radioButton_nam";
            this.radioButton_nam.Size = new System.Drawing.Size(56, 20);
            this.radioButton_nam.TabIndex = 44;
            this.radioButton_nam.TabStop = true;
            this.radioButton_nam.Text = "Nam";
            this.radioButton_nam.UseVisualStyleBackColor = true;
            this.radioButton_nam.CheckedChanged += new System.EventHandler(this.radioButton_nam_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(16, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Giới tính:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // DataGridView_SinhVien
            // 
            this.DataGridView_SinhVien.AllowUserToAddRows = false;
            this.DataGridView_SinhVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_SinhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_SinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_SinhVien.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridView_SinhVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_SinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_SinhVien.ColumnHeadersHeight = 25;
            this.DataGridView_SinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_SinhVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_SinhVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_SinhVien.Location = new System.Drawing.Point(0, 77);
            this.DataGridView_SinhVien.Name = "DataGridView_SinhVien";
            this.DataGridView_SinhVien.RowHeadersVisible = false;
            this.DataGridView_SinhVien.RowTemplate.Height = 40;
            this.DataGridView_SinhVien.Size = new System.Drawing.Size(824, 367);
            this.DataGridView_SinhVien.TabIndex = 36;
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
            // 
            // ComboBox_ChonLop
            // 
            this.ComboBox_ChonLop.FormattingEnabled = true;
            this.ComboBox_ChonLop.Location = new System.Drawing.Point(509, 38);
            this.ComboBox_ChonLop.Name = "ComboBox_ChonLop";
            this.ComboBox_ChonLop.Size = new System.Drawing.Size(211, 21);
            this.ComboBox_ChonLop.TabIndex = 53;
            this.ComboBox_ChonLop.SelectedIndexChanged += new System.EventHandler(this.ComboBox_ChonLop_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(431, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "Chọn lớp:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton_gioitinhall
            // 
            this.radioButton_gioitinhall.AutoSize = true;
            this.radioButton_gioitinhall.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_gioitinhall.ForeColor = System.Drawing.SystemColors.Highlight;
            this.radioButton_gioitinhall.Location = new System.Drawing.Point(249, 450);
            this.radioButton_gioitinhall.Name = "radioButton_gioitinhall";
            this.radioButton_gioitinhall.Size = new System.Drawing.Size(65, 20);
            this.radioButton_gioitinhall.TabIndex = 45;
            this.radioButton_gioitinhall.TabStop = true;
            this.radioButton_gioitinhall.Text = "Tất cả";
            this.radioButton_gioitinhall.UseVisualStyleBackColor = true;
            this.radioButton_gioitinhall.CheckedChanged += new System.EventHandler(this.radioButton_gioitinhall_CheckedChanged);
            // 
            // button_tim
            // 
            this.button_tim.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_tim.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tim.ForeColor = System.Drawing.Color.White;
            this.button_tim.Location = new System.Drawing.Point(726, 34);
            this.button_tim.Name = "button_tim";
            this.button_tim.Size = new System.Drawing.Size(93, 27);
            this.button_tim.TabIndex = 55;
            this.button_tim.Text = "Tìm";
            this.button_tim.UseVisualStyleBackColor = false;
            this.button_tim.Click += new System.EventHandler(this.button_tim_Click);
            // 
            // FormSinhVienIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 491);
            this.Controls.Add(this.button_tim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBox_ChonLop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_in);
            this.Controls.Add(this.radioButton_gioitinhall);
            this.Controls.Add(this.radioButton_nu);
            this.Controls.Add(this.radioButton_nam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataGridView_SinhVien);
            this.Name = "FormSinhVienIn";
            this.Text = "FormSinhVienIn";
            this.Load += new System.EventHandler(this.FormSinhVienIn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_SinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_in;
        private System.Windows.Forms.RadioButton radioButton_nu;
        private System.Windows.Forms.RadioButton radioButton_nam;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_SinhVien;
        private System.Windows.Forms.ComboBox ComboBox_ChonLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_gioitinhall;
        private System.Windows.Forms.Button button_tim;
    }
}