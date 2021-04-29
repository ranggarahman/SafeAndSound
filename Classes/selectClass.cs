using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeAndSound.Classes
{
    class selectClass : detailClass
    {
        //Memilih (selecting) data dari database
        protected DataTable Select()
        {
            //membuat (establishing) koneksi database
            //Ini contoh class yang sudah sedikit ter-implementasi
            //Implementasi class lain akan menyusul
            SqlConnection conn = new SqlConnection(Myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Menuliskan query SQL
                string sql = "SELECT * from tbl_contact";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Membuat SQL Data Adapter menggunakan cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
