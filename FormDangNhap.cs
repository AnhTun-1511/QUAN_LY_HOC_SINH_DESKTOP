using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class FormDangNhap : Form
    {
        SinhVienClass sv = new SinhVienClass();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_eye_Click(object sender, EventArgs e)
        {
            if (textBox_MatKhau.UseSystemPasswordChar == true)
            {
                textBox_MatKhau.UseSystemPasswordChar = false;
                pictureBox_eye.Image = Properties.Resources.see_eye;
            }
            else
            {
                textBox_MatKhau.UseSystemPasswordChar = true;
                pictureBox_eye.Image = Properties.Resources.not_see_eye;
            }

        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            if (textBox_MatKhau.Text == "" || textBox_TenDangNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DBConnect connect = new DBConnect();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `username`=@user AND `password`=@pass", connect.GetConnection);

            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = textBox_TenDangNhap.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBox_MatKhau.Text;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
