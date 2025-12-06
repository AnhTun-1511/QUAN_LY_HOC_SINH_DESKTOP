using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class FormQuanLySinhVien : Form
    {
        SinhVienClass sv = new SinhVienClass();
        public FormQuanLySinhVien()
        {
            InitializeComponent();
        }


        private void DataGridView_SinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       

        private void FormQuanLySinhVien_Load(object sender, EventArgs e)
        {
            xuatBang();
        }
        //Hiển thị bảng sinh viên 
        public void xuatBang()
        {
            SinhVienClass sv = new SinhVienClass();
            DataGridView_SinhVien.DataSource = sv.getSinhVienList();
            DataGridView_SinhVien.Columns["HO"].HeaderText = "Họ";
            DataGridView_SinhVien.Columns["TEN"].HeaderText = "Tên";
            DataGridView_SinhVien.Columns["NGAYSINH"].HeaderText = "Ngày Sinh";
            DataGridView_SinhVien.Columns["GIOITINH"].HeaderText = "Giới Tính";
            DataGridView_SinhVien.Columns["DIENTHOAI"].HeaderText = "Điện Thoại";
            DataGridView_SinhVien.Columns["DIACHI"].HeaderText = "Địa Chỉ";
            DataGridView_SinhVien.Columns["ANH"].HeaderText = "Ảnh";
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            DataGridView_SinhVien.RowTemplate.Height = 80;
            imageColumn = (DataGridViewImageColumn)DataGridView_SinhVien.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        //Hiển thị dữ liệu sinh viên từ textbox

        private void DataGridView_SinhVien_Click(object sender, EventArgs e)
        {
            
            if (DataGridView_SinhVien.CurrentRow == null || DataGridView_SinhVien.CurrentRow.Index == -1)
            {
                return;
            }

            try
            {
               
                textBox_SinhVienId.Text = DataGridView_SinhVien.CurrentRow.Cells["ID"].Value.ToString();
                textBox_ho.Text = DataGridView_SinhVien.CurrentRow.Cells["HO"].Value.ToString();
                textBox_ten.Text = DataGridView_SinhVien.CurrentRow.Cells["TEN"].Value.ToString();
                dateTimePicker_ngaysinh.Value = (DateTime)DataGridView_SinhVien.CurrentRow.Cells["NGAYSINH"].Value;

                string gioitinh = DataGridView_SinhVien.CurrentRow.Cells["GIOITINH"].Value.ToString().Trim();
                if (gioitinh == "Nam")
                {
                    radioButton_nam.Checked = true;
                }
                else
                {
                    radioButton_nu.Checked = true;
                }

                textBox_sdt.Text = DataGridView_SinhVien.CurrentRow.Cells["DIENTHOAI"].Value.ToString();
                textBox_diachi.Text = DataGridView_SinhVien.CurrentRow.Cells["DIACHI"].Value.ToString();

                var anhData = DataGridView_SinhVien.CurrentRow.Cells["ANH"].Value;
                if (anhData != DBNull.Value)
                {
                    byte[] anh = (byte[])anhData;
                    MemoryStream ms = new MemoryStream(anh);
                    pictureBox_sinhvien.Image = Image.FromStream(ms);
                }
                else
                {
                    pictureBox_sinhvien.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void button_xoathongtin_Click(object sender, EventArgs e)
        {
            textBox_SinhVienId.Clear();
            textBox_ho.Clear();
            textBox_ten.Clear();
            textBox_sdt.Clear();
            textBox_diachi.Clear();
            radioButton_nam.Checked = true;
            dateTimePicker_ngaysinh.Value = DateTime.Now;
            pictureBox_sinhvien.Image = null;
        }

        private void button_taianh_Click(object sender, EventArgs e)
        {
            // tải ảnh
            // tải ảnh từ máy tính lên PictureBox
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Chọn ảnh(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_sinhvien.Image = Image.FromFile(opf.FileName);
            }
        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            SinhVienClass sv = new SinhVienClass();
            DataGridView_SinhVien.DataSource = sv.TimKiemSinhVien(textBox_TimKiem.Text);
            DataGridView_SinhVien.Columns["HO"].HeaderText = "Họ";
            DataGridView_SinhVien.Columns["TEN"].HeaderText = "Tên";
            DataGridView_SinhVien.Columns["NGAYSINH"].HeaderText = "Ngày Sinh";
            DataGridView_SinhVien.Columns["GIOITINH"].HeaderText = "Giới Tính";
            DataGridView_SinhVien.Columns["DIENTHOAI"].HeaderText = "Điện Thoại";
            DataGridView_SinhVien.Columns["DIACHI"].HeaderText = "Địa Chỉ";
            DataGridView_SinhVien.Columns["ANH"].HeaderText = "Ảnh";
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            DataGridView_SinhVien.RowTemplate.Height = 80;
            imageColumn = (DataGridViewImageColumn)DataGridView_SinhVien.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void textBox_TimKiem_TextChanged(object sender, EventArgs e)
        {

        }
        //Hàm kiểm tra dữ liệu nhập vào
        bool xacnhan()
        {
            if ((textBox_ho.Text == "") || (textBox_ten.Text == "") || (textBox_diachi.Text == "") || (textBox_sdt.Text == "") || (pictureBox_sinhvien.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button_capnhat_Click(object sender, EventArgs e)
        {
            // câp nhật thông tin sinh viên
            int id = Convert.ToInt32( textBox_SinhVienId.Text);
            string ho = textBox_ho.Text;
            string ten = textBox_ten.Text;
            DateTime ngaysinh = dateTimePicker_ngaysinh.Value;
            string gioitinh = radioButton_nam.Checked ? "Nam" : "Nữ";
            string diachi = textBox_diachi.Text;
            string sdt = textBox_sdt.Text;
            //Lấy ảnh từ PictureBox 
            MemoryStream anh = new MemoryStream();
            pictureBox_sinhvien.Image.Save(anh, pictureBox_sinhvien.Image.RawFormat);
            byte[] anhbyte = anh.ToArray();
            //kiểm tra tuổi sinh viên
            int namsinh = dateTimePicker_ngaysinh.Value.Year;
            int namhientai = DateTime.Now.Year;
            if ((namhientai - namsinh) < 18 || (namhientai - namsinh) > 100)
            {
                MessageBox.Show("Tuổi sinh viên phải từ 18 đến 100 tuổi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (xacnhan() == false)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SinhVienClass sv = new SinhVienClass();
                bool themsv = sv.CapNhatSinhVien(id,ho, ten, ngaysinh, gioitinh, diachi, sdt, anhbyte);
                if (themsv)
                {
                    xuatBang();
                    MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật sinh viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button_xoasinhvien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_SinhVienId.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xoá.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = Convert.ToInt32(textBox_SinhVienId.Text);
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá sinh viên này không?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SinhVienClass sv = new SinhVienClass();
                if (sv.XoaSinhVien(id))
                {
                    MessageBox.Show("Xoá sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    xuatBang();
                    button_xoathongtin_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Xoá sinh viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
