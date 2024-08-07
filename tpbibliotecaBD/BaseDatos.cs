using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpbibliotecaBD
{
    internal class BaseDatos
    {
        static SqlConnection conn = new SqlConnection();
        private static bool Connection()
        {
            conn.ConnectionString = @"Data Source=LAPTOP-6F0U2DCR;Initial Catalog=InvLibros;Integrated Security=True";
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private static void Disconnect()
        {
            conn.Close();
        }


        public static bool ExecuteQuery(string SqlConsult)
        {
            bool correcto = false;
            try
            {
                Connection();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(SqlConsult, conn);
                da.Fill(dt);
                correcto = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                correcto = false;
            }
            finally
            {
                Disconnect();
            }
            return correcto;
        }
        public static DataTable Search(string SqlConsult)
        {
            DataTable dt = new DataTable();
            try
            {
                Connection();
                SqlDataAdapter da = new SqlDataAdapter(SqlConsult, conn);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                dt = null;
            }
            finally
            {
                Disconnect();
            }
            return dt;

        }
    }
}
