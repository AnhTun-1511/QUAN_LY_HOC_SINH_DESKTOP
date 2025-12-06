using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh
{
    internal class KhoaHocClass
    {
        DBConnect connect=new DBConnect();
        // Hàm thêm khoá học
        public bool ThemKhoaHoc(string TenKhoaHoc,int GioHoc, string ChiTietKhoaHoc)
        {
            MySqlCommand command= new MySqlCommand("INSERT INTO `khoahoc`(`TenKhoaHoc`, `GioKhoaHoc`, `ChiTietKhoaHoc`) VALUES (@tenkhoa,@giohoc,@chitiet)",connect.GetConnection);
            //@tenkhoa,@giohoc,@chitiet
            command.Parameters.Add("@tenkhoa",MySqlDbType.VarChar).Value=TenKhoaHoc;
            command.Parameters.Add("@giohoc",MySqlDbType.Int32).Value=GioHoc;
            command.Parameters.Add("@chitiet",MySqlDbType.VarChar).Value= ChiTietKhoaHoc;
            connect.OpenConnection();
            if (command.ExecuteNonQuery()==1)
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
        // Hàm getlist khoá học
        public DataTable GetListKhoaHoc(MySqlCommand command)
        {
            command.Connection = connect.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //Hàm cập nhật khoá học
        public bool CapNhatKhoaHoc(int id,string TenKhoaHoc, int GioHoc, string ChiTietKhoaHoc)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `khoahoc` SET `TenKhoaHoc`=@tenkhoa,`GioKhoaHoc`=@giohoc,`ChiTietKhoaHoc`=@chitiet WHERE `IdKhoaHoc`=@id", connect.GetConnection);
            //@id,@tenkhoa,@giohoc,@chitiet
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@tenkhoa", MySqlDbType.VarChar).Value = TenKhoaHoc;
            command.Parameters.Add("@giohoc", MySqlDbType.Int32).Value = GioHoc;
            command.Parameters.Add("@chitiet", MySqlDbType.VarChar).Value = ChiTietKhoaHoc;
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
        //Hàm xoá khoá học
        public bool XoaKhoaHoc(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `khoahoc` WHERE `IdKhoaHoc`=@id", connect.GetConnection);
            //@id
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
    }
}
