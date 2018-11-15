using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HURIS
{
    public class DBConnectionController
    {
        static SqlConnection connection;
        static SqlDataAdapter adapter = new SqlDataAdapter();
        static SqlCommand cmd = new SqlCommand();
        static SqlCommand con = new SqlCommand();
        static string connetionString = null;
        static DataTable dtItems = new DataTable();
        public DBConnectionController()
        {
            connetionString = "Data Source=JUSTINE-PC;Initial Catalog=SampleDatabase;User ID=justin;Password=123";
            connection = new SqlConnection(connetionString);
        }

        public bool ExecNonQuery(SqlCommand cmd)
        {
            connection.Open();
            cmd.Connection = connection;
         
           // SqlCommand cmd = new SqlCommand("usp_EmployeeRegister", connection);
           //
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();

            connection.Close();

            return Convert.ToBoolean(cmd.ExecuteNonQuery());
        }
        public static DataTable ExecDataReadr(SqlCommand cmd)
        {

            return dtItems;
        }
    }
}
