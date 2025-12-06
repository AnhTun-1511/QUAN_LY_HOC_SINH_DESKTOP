using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace QuanLyHocSinh
{
    // kết nối cơ sở dữ liệu
    // tải xampp và mysql connector
    internal class DBConnect
    {
        //tạo kết nối
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=sinhviendb");
        // mở kết nối
        public MySqlConnection GetConnection
        {
            get
            {
                return connection;
            }
        }
        #region Hàm mở kết nối
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        #endregion
        #region Hàm đóng kết nối
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        #endregion
    }
}
