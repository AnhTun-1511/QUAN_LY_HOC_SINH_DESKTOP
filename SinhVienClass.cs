using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Mysqlx.Datatypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuanLyHocSinh
{
    internal class SinhVienClass
    {
        DBConnect connect = new DBConnect();
        public bool themSinhVien(string ho, string ten, DateTime ngaysinh, string gioitinh, string diachi, string sdt, byte[] anh)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `sinhvien`(`HO`, `TEN`, `NGAYSINH`, `DIENTHOAI`, `GIOITINH`, `DIACHI`, `ANH`) VALUES(@ho, @ten, @ngaysinh, @dienthoai, @gioitinh, @diachi, @anh)", connect.GetConnection);
            //@ho, @ten, @ngaysinh, @dienthoai, @gioitinh, @diachi, @anh
            command.Parameters.Add("@ho", MySqlDbType.VarChar).Value = ho;
            command.Parameters.Add("@ten", MySqlDbType.VarChar).Value = ten;
            command.Parameters.Add("@ngaysinh", MySqlDbType.Date).Value = ngaysinh;
            command.Parameters.Add("@dienthoai", MySqlDbType.VarChar).Value = sdt;
            command.Parameters.Add("@gioitinh", MySqlDbType.VarChar).Value = gioitinh;
            command.Parameters.Add("@diachi", MySqlDbType.VarChar).Value = diachi;
            command.Parameters.Add("@anh", MySqlDbType.Blob).Value = anh;
            connect.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseConnection();
                return true;
            }
            else
            {
                connect.CloseConnection();
                return false;
            }
        }
        // lấy bảng sinh viên
        public DataTable getSinhVienList()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `sinhvien`", connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
        // Hàm thực hiện query đếm sinh viên: tổng, nam , nữ
        public string exeDemSinhVien(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connect.GetConnection);
            connect.OpenConnection();
            string count = command.ExecuteScalar().ToString();
            connect.CloseConnection();
            return count;
        }
        // tính tổng sinh viên
        public string TongSinhVien()
        {
            return exeDemSinhVien("SELECT COUNT(*) FROM sinhvien");
        }
        // tính sinh viên nam
        public string TongSinhVienNam()
        {
            return exeDemSinhVien("SELECT COUNT(*) FROM sinhvien WHERE GIOITINH='Nam'");
        }
        // tính sinh viên nữ
        public string TongSinhVienNu()
        {
            return exeDemSinhVien("SELECT COUNT(*) FROM sinhvien WHERE GIOITINH='Nữ'");
        }
        //Hàm tìm kiếm sinh viên (họ, tên, địa chỉ)
        //Hàm tìm kiếm sinh viên (họ, tên, địa chỉ, giới tính)
        public DataTable TimKiemSinhVien(string du_lieu_tim_kiem)
        {
            // Dùng tham số @timkiem thay vì cộng chuỗi để tăng tính bảo mật
            //Nếu lỡ nhập drop table sinhvien thì cũng không bị mất dữ liệu
            string query = "SELECT * FROM `sinhvien` WHERE CONCAT(`HO`,`TEN`,`DIACHI`,`GIOITINH`) LIKE @timkiem";

            MySqlCommand command = new MySqlCommand(query, connect.GetConnection);
            //Thêm tham số @timkiem một cách an toàn
            command.Parameters.AddWithValue("@timkiem", "%" + du_lieu_tim_kiem + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        //Hàm sửa thông tin sinh viên
        public bool CapNhatSinhVien(int id, string ho, string ten, DateTime ngaysinh, string gioitinh, string diachi, string sdt, byte[] anh)
        {
            string query = "UPDATE `sinhvien` SET `HO`=@ho, `TEN`=@ten, `NGAYSINH`=@ngaysinh, `DIENTHOAI`=@dienthoai, `GIOITINH`=@gioitinh, `DIACHI`=@diachi, `ANH`=@anh WHERE `ID`=@id";
            MySqlCommand command = new MySqlCommand(query, connect.GetConnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@ho", MySqlDbType.VarChar).Value = ho;
            command.Parameters.Add("@ten", MySqlDbType.VarChar).Value = ten;
            command.Parameters.Add("@ngaysinh", MySqlDbType.Date).Value = ngaysinh;
            command.Parameters.Add("@dienthoai", MySqlDbType.VarChar).Value = sdt;
            command.Parameters.Add("@gioitinh", MySqlDbType.VarChar).Value = gioitinh;
            command.Parameters.Add("@diachi", MySqlDbType.VarChar).Value = diachi;
            command.Parameters.Add("@anh", MySqlDbType.Blob).Value = anh;

            connect.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseConnection();
                return true;
            }
            else
            {
                connect.CloseConnection();
                return false;
            }
        }
        //Hàm xoá sinh viên
        public bool XoaSinhVien(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `sinhvien` WHERE `ID`=@id", connect.GetConnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            connect.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseConnection();
                return true;
            }
            else
            {
                connect.CloseConnection();
                return false;
            }
        }
        // Hàm lấy danh sách sinh viên dựa trên câu lệnh MySqlCommand
        public DataTable GetList(MySqlCommand command)
        {
            command.Connection = connect.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}

