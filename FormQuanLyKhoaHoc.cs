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
    public partial class FormQuanLyKhoaHoc : Form
    {
        KhoaHocClass khoahoc = new KhoaHocClass();
        public FormQuanLyKhoaHoc()
        {
            InitializeComponent();
        }

        private void FormQuanLyKhoaHoc_Load(object sender, EventArgs e)
        {
            ShowData();
        }
        private void ShowData()
        {
            // hiển thị ds ở datagridview
            DataGridView_KhoaHoc.DataSource = khoahoc.GetListKhoaHoc(new MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM `khoahoc`"));
        }

        private void textBox_GioHoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button_XoaThongTin_Click(object sender, EventArgs e)
        {
            textBox_IdKhoaHoc.Clear();
            textBox_TenKhoaHoc.Clear();
            textBox_GioHoc.Clear();
            textBox_ThongTin.Clear();
        }

        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            if (textBox_TenKhoaHoc.Text == "" || textBox_ThongTin.Text == "" || textBox_IdKhoaHoc.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int idKhoaHoc = Convert.ToInt32(textBox_IdKhoaHoc.Text);
                string TenKhoaHoc = textBox_TenKhoaHoc.Text;
                int GioHoc = Convert.ToInt32(textBox_GioHoc.Text);
                string ChiTietKhoaHoc = textBox_ThongTin.Text;
                if (khoahoc.CapNhatKhoaHoc(idKhoaHoc, TenKhoaHoc, GioHoc, ChiTietKhoaHoc))
                {
                    ShowData();
                    button_XoaThongTin.PerformClick();
                    MessageBox.Show("Cập nhật khoá học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật khoá học thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_XoaKhoaHoc_Click(object sender, EventArgs e)
        {
            if (textBox_IdKhoaHoc.Text.Equals(""))
            {
                MessageBox.Show("Cần Id khoá học!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int idKhoaHoc = Convert.ToInt32(textBox_IdKhoaHoc.Text);
                    if (khoahoc.XoaKhoaHoc(idKhoaHoc))
                    {
                        ShowData();
                        button_XoaThongTin.PerformClick();
                        MessageBox.Show("Xoá khoá học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DataGridView_KhoaHoc_Click(object sender, EventArgs e)
        {
            if (DataGridView_KhoaHoc.CurrentRow == null || DataGridView_KhoaHoc.CurrentRow.Index == -1)
            {
                return;
            }
            try
            {
                textBox_IdKhoaHoc.Text = DataGridView_KhoaHoc.CurrentRow.Cells["IDKHOAHOC"].Value.ToString();
                textBox_TenKhoaHoc.Text = DataGridView_KhoaHoc.CurrentRow.Cells["TENKHOAHOC"].Value.ToString();
                textBox_GioHoc.Text = DataGridView_KhoaHoc.CurrentRow.Cells["GIOHOC"].Value.ToString();
                textBox_ThongTin.Text = DataGridView_KhoaHoc.CurrentRow.Cells["CHITIETKHOAHOC"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
    }
}
