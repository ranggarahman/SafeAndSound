using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeAndSound.Classes
{
    class deleteClass : detailClass
    {
        public bool Delete(detailClass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                /*
                 * Disini dilakukan beberapa hal
                 * 1. Membuat SQL untuk deletion data
                 * 2. Membuat command SQL dan membuka connection
                 * 3. Pengecekan kondisi apakah query berhasil dijalankan, jika iya maka nilai rows > 0
                 */
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
            return isSuccess;
        }
    }
}
