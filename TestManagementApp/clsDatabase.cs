using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestManagementApp
{
    internal class clsDatabase
    {
        public static SqlConnection con;

        //public static bool OpenConnection()
        //{
        //    try
        //    {
        //        // Sửa lại tên server cho phù hợp với mỗi máy
        //        con = new SqlConnection("Server=DESKTOP-UCGD4BF\\SQLEXPRESS;Database=QL_TRAC_NGHIEM;Integrated Security=true");
        //        con.Open();
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        //public static bool CloseConnection()
        //{
        //    try
        //    {
        //        con.Close();
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //    return true;
        //}
    }
}
