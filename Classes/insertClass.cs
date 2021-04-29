using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeAndSound.Classes
{
    class insertClass : detailClass
    {
        protected bool Insert (detailClass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(Myconnstrng);
            try
            {
                /*Disini akan dilakukan beberapa hal : 
                 1. Membuat SQL Query untuk insertion data
                 2. Membuat parameter-parameter yang perlu untuk memasukkan data tersebut
                 3. Membuka connection, e.g conn.Open();
                 4. Pengecekan kondisi apakah query berhasil dijalankan, jika iya maka nilai rows > 0
                */

            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
    }
}
