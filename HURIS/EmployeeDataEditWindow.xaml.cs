using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace HURIS
{

    /// <summary>
    /// Interaction logic for EmployeeDataEditWindow.xaml
    /// </summary>
    public partial class EmployeeDataEditWindow : Window
    {
        SqlConnection connection;
        SqlDataReader reader;
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlCommand con = new SqlCommand();
        string connetionString = null;

        public EmployeeDataEditWindow(string id)
        {
            InitializeComponent();
            connetionString = "Data Source=JUSTINE-PC;Initial Catalog=SampleDatabase;User ID=justin;Password=123";
            connection = new SqlConnection(connetionString);

            connection.Open();

            SqlCommand cmd = new SqlCommand("usp_EmployeeIndividualRecord", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpID", id);

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtEmpID.Text = reader["EmpID"].ToString();
                txtFirstName.Text = reader["FirstName"].ToString();
                txtLastName.Text = reader["LastName"].ToString();
                txtContact.Text = reader["ContactNumber"].ToString();
            }
            connection.Close();
        }

        private void EmployeeDataUpdate()
        {
            try
            {
                connection.Open();

                string id = txtEmpID.Text.ToString();
                string fname = txtFirstName.Text.ToString();
                string lname = txtLastName.Text.ToString();
                string contactno = txtContact.Text.ToString();

                SqlCommand cmd = new SqlCommand("usp_EmployeeDataUpdate", connection);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@Firstname", fname);
                cmd.Parameters.AddWithValue("@Lastname", lname);
                cmd.Parameters.AddWithValue("@Contact", contactno);
                cmd.Parameters.AddWithValue("@EmpID", id);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Updated Successfully!");

                this.Close();


                connection.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
           
        }

        private void ClickButtonEvent(object sender, RoutedEventArgs e)
        {
            if (sender == btnEmployeeUpdate)
                EmployeeDataUpdate();
        }
    }
}
