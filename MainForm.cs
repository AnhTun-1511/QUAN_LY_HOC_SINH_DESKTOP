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
    public partial class MainForm : Form
    {
        SinhVienClass sv = new SinhVienClass();
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DemSinhVien();
        }
           
        private void DemSinhVien()
        {
            // in ra tổng số sinh viên 
            label_TongSoSinhVien.Text = "Tổng số sinh viên: " + sv.TongSinhVien();
            label_TongSinhVienNam.Text = "Sv nam: " + sv.TongSinhVienNam();
            label_TongSinhVienNu.Text = "Sv nữ: " + sv.TongSinhVienNu();
        }
        private void customizeDesign()
        {
            panel_SinhVienSubMenu.Visible = false;
            panel_DiemSubMenu.Visible = false;
            panel_KhoaHocSubMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panel_SinhVienSubMenu.Visible == true)
                panel_SinhVienSubMenu.Visible = false;
            if (panel_DiemSubMenu.Visible == true)
                panel_DiemSubMenu.Visible = false;
            if (panel_KhoaHocSubMenu.Visible == true)
                panel_KhoaHocSubMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void btn_SinhVien_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_SinhVienSubMenu);
        }
        #region SinhVienSubMenu

        private void button_btnSinhVienDangKy(object sender, EventArgs e)
        {
            OpenChildForm(new FormDangKySinhVien());
            //..
            //..my code
            //..
            hideSubMenu(); 
        }

        private void button_btnSinhVienQuanLy(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLySinhVien());
            //..
            //..my code
            //..
            hideSubMenu();
        }

        private void button_btnSinhVienThongTin(object sender, EventArgs e)
        {
            //..
            //..my code
            //..
            hideSubMenu();
        }

        private void button_btnSinhVienIn(object sender, EventArgs e)
        {
            OpenChildForm(new FormSinhVienIn());
            //..
            //..my code
            //..
            hideSubMenu();
        }
        #endregion SinhVienSubMenu
        private void button_btnKhoaHoc(object sender, EventArgs e)
        {
           
            showSubMenu(panel_KhoaHocSubMenu);
        }
        #region KhoaHocSubMenu


        private void button_KhoaHocMoi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDangKyKhoaHoc());
            //..
            //..my code
            //..
            hideSubMenu();
        }

        private void button_QuanLyKhoaHoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLyKhoaHoc());
            //..
            //..my code
            //..
            hideSubMenu();
        }

        private void button_KhoaHocXuat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormKhoaHocIn());
            //..
            //..my code
            //..
            hideSubMenu();
        }
        #endregion KhoaHocSubMenu
        private void button_Diem_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_DiemSubMenu);
        }

        #region DiemSubMenu

        private void button_DiemMoi_Click(object sender, EventArgs e)
        {
            //..
            //..my code
            //..
            hideSubMenu();
        }

        private void button_QuanLyDiem_Click(object sender, EventArgs e)
        {
            //..
            //..my code
            //..
            hideSubMenu();
        }

        private void button_DiemXuat_Click(object sender, EventArgs e)
        {
            //..
            //..my code
            //..
            hideSubMenu();
        }
        #endregion DiemSubMenu
        // Hiển thị đăng ký trong cái main form
        private Form activeForm = null;
        private void OpenChildForm(Form ChildForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(ChildForm);
            panel_main.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
                activeForm.Close();
            panel_main.Controls.Add(panel_cover);
            DemSinhVien();
        }
    }
}
