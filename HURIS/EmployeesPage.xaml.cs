using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HURIS
{
    /// <summary>
    /// Interaction logic for Employees.xaml
    /// </summary>
    public partial class Employees : Page
    {
        SqlConnection connection;
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlCommand con = new SqlCommand();
        string connetionString = null;

        DataTable dtItems = new DataTable();
        public Employees()
        {
            InitializeComponent();
            //connetionString = "Data Source=192.168.1.200;Initial Catalog=USLS;User ID=sa;Password=Hybrain2018";
            connetionString = "Data Source=JUSTINE-PC;Initial Catalog=SampleDatabase;User ID=justin;Password=123";
            connection = new SqlConnection(connetionString);
            LoadData(null);
        }

        private void LoadData(string Keywords)
        {

            Keywords = (string.IsNullOrEmpty(Keywords) == true ? "" : Keywords); //inline if-else condition
            connection.Open();

            //Connecting to  Stored Procedure
            SqlCommand cmd = new SqlCommand("usp_EmployeeSearch", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            //Sends the  parameter keyword to the query
            cmd.Parameters.AddWithValue("@Keywords", Keywords);

            
            //Loading the table
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dtItems = dt;
            dataGridView1.ItemsSource = dtItems.DefaultView;
   
            connection.Close();
        }


        private void AddEmployee()
        {
            EmployeeRegistrationForm add = new EmployeeRegistrationForm();
            add.ShowDialog();
            if(add.DialogResult == true)
                LoadData(null);
        }

        private void ClickButtonEvent(object sender, RoutedEventArgs e)
        {
            try
            {
                //Detects what's the value of sender
                if (sender == btnSearch)
                    LoadData(txtSearch.Text);
                else if (sender == btnAddEmployee)
                    AddEmployee();
                // SaveData();

            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }

        private void btnEdit(object sender, RoutedEventArgs e)
        {

            DataRowView rowview = dataGridView1.SelectedItem as DataRowView;
            string id = rowview.Row["EmpID"].ToString();

            EmployeeDataEditWindow edt = new EmployeeDataEditWindow(id);
            edt.ShowDialog();

            if (edt.DialogResult == true)
                LoadData(null);
        }

        private void dataGridView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

