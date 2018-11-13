using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace HURIS
{
    /// <summary>
    /// Interaction logic for Sample.xaml
    /// </summary>
    public partial class Sample : Window
    {

        SqlConnection connection;
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlCommand con = new SqlCommand();
        string connetionString = null;

        DataTable dtItems = new DataTable();
        public Sample()
        {
            InitializeComponent();
            connetionString = "Data Source=192.168.1.200;Initial Catalog=USLS;User ID=sa;Password=Hybrain2018";
            connection = new SqlConnection(connetionString);
            LoadData(null);
        }

        private void SaveData()
        {

            connection.Open();
            string fname = txtFirstName.Text.ToString();
            string lname = txtLastName.Text.ToString();
            string contact = txtContact.Text.ToString();

            SqlCommand cmd = new SqlCommand("usp_StudentRegister", connection);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@contact", contact);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Successful!");
            LoadData(null);
        }
        private void LoadData(string Keywords)
        {
            Keywords = (string.IsNullOrEmpty(Keywords) == true ? "" : Keywords); //inline ifelse condition
            connection.Open();
            SqlCommand cmd = new SqlCommand("usp_StudentsSearch", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            //sda.Connection = connection;
            cmd.Parameters.AddWithValue("@Keywords",Keywords);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dtItems = dt;
            dataGridView1.ItemsSource = dtItems.DefaultView;
            connection.Close();

            //or
            //dataGridView1.ItemsSource = dt.DefaultView;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ClickButtonEvent(object sender, RoutedEventArgs e)
        {
            try
            {
                if (sender == btnSearch)
                    LoadData(txtSearch.Text);
                else if (sender == btnSubmit)
                    SaveData();
            }
            catch(Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }
    }
}
