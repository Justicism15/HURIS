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
    /// Interaction logic for EmployeeRegistrationForm.xaml
    /// </summary>
    public partial class EmployeeRegistrationForm : Window
    {

        SqlConnection connection;
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlCommand con = new SqlCommand();
        string connetionString = null;

        DataTable dtItems = new DataTable();
        public EmployeeRegistrationForm()
        {
            InitializeComponent();
            connetionString = "Data Source=JUSTINE-PC;Initial Catalog=SampleDatabase;User ID=justin;Password=123";
            connection = new SqlConnection(connetionString);
        }

        private void SaveData()
        {
            connection.Open();
            string fname = txtFirstName.Text.ToString();
            string lname = txtLastName.Text.ToString();
            string contact = txtContact.Text.ToString();

            SqlCommand cmd = new SqlCommand("usp_EmployeeRegister", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@contact", contact);

  
            cmd.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Successful!");
            DialogResult = true;
        }

    


        private void ClickButtonEvent(object sender, RoutedEventArgs e)
        {
            if (sender == btnSubmit)
            {
                SaveData();
            }
             
        }
    }
}
