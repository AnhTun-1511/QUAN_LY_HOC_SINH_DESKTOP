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
    public partial class FormKhoaHocIn : Form
    {
        KhoaHocClass khoaHoc = new KhoaHocClass();
        public FormKhoaHocIn()
        {
            InitializeComponent();
        }

        private void radioButton_gioitinhall_CheckedChanged(object sender, EventArgs e)
        {
                    }

        private void DataGridView_SinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
