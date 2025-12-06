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
    public partial class FormDangKyKhoaHoc : Form
    {
        KhoaHocClass khoahoc = new KhoaHocClass();
        public FormDangKyKhoaHoc()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_them_Click(object sender, EventArgs e)
        {
            if (textBox_TenKhoaHoc.Text == "" || textBox_ThongTin.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string TenKhoaHoc = textBox_TenKhoaHoc.Text;
                int GioHoc = Convert.ToInt32(textBox_GioHoc.Text);
                string ChiTietKhoaHoc = textBox_ThongTin.Text;
                if (khoahoc.ThemKhoaHoc(TenKhoaHoc, GioHoc, ChiTietKhoaHoc))
                {
                    ShowData();
                    button_xoathongtin.PerformClick();
                    MessageBox.Show("Khoá học đã được thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm khoá học thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_xoathongtin_Click(object sender, EventArgs e)
        {
            textBox_TenKhoaHoc.Clear();
            textBox_GioHoc.Clear();
            textBox_ThongTin.Clear();
        }

        private void FormDangKyKhoaHoc_Load(object sender, EventArgs e)
        {
            ShowData();
        }
        private void ShowData()
        {
            // hiển thị ds ở datagridview
            DataGridView_KhoaHoc.DataSource = khoahoc.GetListKhoaHoc(new MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM `khoahoc`"));
        }
    }
}
