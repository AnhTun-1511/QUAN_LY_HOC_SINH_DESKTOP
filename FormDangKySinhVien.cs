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
    public partial class FormDangKySinhVien : Form
    {
        public FormDangKySinhVien()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_taianh_Click(object sender, EventArgs e)
        {
            // tải ảnh
            // tải ảnh từ máy tính lên PictureBox
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter="Chọn ảnh(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if(opf.ShowDialog()==DialogResult.OK)
            {
                pictureBox_sinhvien.Image = Image.FromFile(opf.FileName);
            }
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            //thêm sinh viên
            string ho = textBox_ho.Text;
            string ten = textBox_ten.Text;
            DateTime ngaysinh = dateTimePicker_ngaysinh.Value;
            string gioitinh=radioButton_nam.Checked ? "Nam" : "Nữ";
            string diachi = textBox_diachi.Text;
            string sdt = textBox_sdt.Text;
            //Lấy ảnh từ PictureBox 
            MemoryStream anh = new MemoryStream();
            pictureBox_sinhvien.Image.Save(anh, pictureBox_sinhvien.Image.RawFormat);
            byte[] anhbyte = anh.ToArray();
            //kiểm tra tuổi sinh viên
            int namsinh = dateTimePicker_ngaysinh.Value.Year;
            int namhientai = DateTime.Now.Year;
            if((namhientai - namsinh)<18 || (namhientai - namsinh)>100)
            {
                MessageBox.Show("Tuổi sinh viên phải từ 18 đến 100 tuổi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(xacnhan()==false)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SinhVienClass sv = new SinhVienClass();
                bool themsv = sv.themSinhVien(ho, ten, ngaysinh, gioitinh, diachi, sdt, anhbyte);
                if(themsv)
                {
                    xuatBang();
                    MessageBox.Show("Thêm sinh viên thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm sinh viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
        //Hàm kiểm tra dữ liệu nhập vào
        bool xacnhan()
        {
            if((textBox_ho.Text=="")||(textBox_ten.Text=="")||(textBox_diachi.Text=="")||(textBox_sdt.Text=="")||(pictureBox_sinhvien.Image==null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            // xoá sinh viên
            textBox_ho.Clear();
            textBox_ten.Clear();
            textBox_sdt.Clear();
            textBox_diachi.Clear();
            radioButton_nam.Checked = true;
            dateTimePicker_ngaysinh.Value = DateTime.Now;
            pictureBox_sinhvien.Image = null;
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {
            xuatBang();
        }
        //hiện bảng sinh viên ra trong datagrid
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

        private void DataGridView_SinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
