using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeAndSound.Classes
{
    class updateClass : detailClass
    {
        public bool Update(detailClass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Disini dilakukan beberapa hal :
                /*
                    1. SQL untuk update data dalam database
                    2. Membuat parameter yang diperlukan untuk update
                    3. Membuka connection, e.g conn.Open();
                    4. Pengecekan kondisi apakah query berhasil dijalankan, jika iya maka nilai rows > 0
                 */
            }
            catch (Exception ex)
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
