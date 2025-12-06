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
using MySql.Data.MySqlClient;
using DGVPrinterHelper;

namespace QuanLyHocSinh
{
    public partial class FormSinhVienIn : Form
    {
        SinhVienClass sinhVienClass = new SinhVienClass();
        DGVPrinter printer = new DGVPrinter();
        public FormSinhVienIn()
        {
            InitializeComponent();
        }

        private void FormSinhVienIn_Load(object sender, EventArgs e)
        {
            InSinhVien(new MySqlCommand("SELECT * FROM `sinhvien`"));
        }
        //Hàm in ra ds sinh viên
        public void InSinhVien(MySqlCommand command)
        {
            DataGridView_SinhVien.ReadOnly = true;

            //  Lấy dữ liệu
            DataGridView_SinhVien.DataSource = sinhVienClass.GetList(command);  
            DataGridView_SinhVien.Columns["HO"].HeaderText = "Họ";
            DataGridView_SinhVien.Columns["TEN"].HeaderText = "Tên";
            DataGridView_SinhVien.Columns["NGAYSINH"].HeaderText = "Ngày Sinh";
            DataGridView_SinhVien.Columns["GIOITINH"].HeaderText = "Giới Tính";
            DataGridView_SinhVien.Columns["DIENTHOAI"].HeaderText = "Điện Thoại";

            DataGridView_SinhVien.Columns["DIACHI"].HeaderText = "Địa Chỉ";
            DataGridView_SinhVien.Columns["ANH"].HeaderText = "Ảnh";

            DataGridViewImageColumn column = new DataGridViewImageColumn();
            DataGridView_SinhVien.RowTemplate.Height = 80; 
            column = (DataGridViewImageColumn)DataGridView_SinhVien.Columns["ANH"];
            column.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void DataGridView_SinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_tim_Click(object sender, EventArgs e)
        {
            // kiểm tra giới tính
            string selectQuery;
            if (radioButton_nam.Checked)
            {
                selectQuery = "SELECT * FROM `sinhvien` WHERE CONCAT(`HO`,`TEN`,`DIACHI`,`DIENTHOAI`) LIKE '%" + ComboBox_ChonLop.Text + "%' AND GIOITINH='Nam'";
            }
            else if (radioButton_nu.Checked)
            {
                selectQuery = "SELECT * FROM `sinhvien` WHERE CONCAT(`HO`,`TEN`,`DIACHI`,`DIENTHOAI`) LIKE '%" + ComboBox_ChonLop.Text + "%' AND GIOITINH='Nữ'";
            }
            else
            {
                selectQuery = "SELECT * FROM `sinhvien` WHERE CONCAT(`HO`,`TEN`,`DIACHI`,`DIENTHOAI`) LIKE '%" + ComboBox_ChonLop.Text + "%'";
            }
            InSinhVien(new MySqlCommand(selectQuery));
        }

        private void button_in_Click(object sender, EventArgs e)
        {
            // tải dgvprinter để in
            printer.Title = "Danh Sách Sinh Viên"; // Tiêu đề chính
            printer.SubTitle = string.Format("Ngày In: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy")); // Tiêu đề phụ
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true; // đánh số trang
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Học viên";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_SinhVien);

        }

        private void ComboBox_ChonLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton_gioitinhall_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_nu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_nam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
