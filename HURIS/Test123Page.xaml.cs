using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HURIS
{
    /// <summary>
    /// Interaction logic for Test123.xaml
    /// </summary>
    public partial class Test123 : Page
    {
        SqlConnection connection;
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlCommand con = new SqlCommand();
        string connetionString = null;

        DataTable dtItems = new DataTable();
        public Test123()
        {
            InitializeComponent();
            //connetionString = "Data Source=192.168.1.200;Initial Catalog=USLS;User ID=sa;Password=Hybrain2018";
            connetionString = "Data Source=JUSTINE-PC;Initial Catalog=SampleDatabase;User ID=justin;Password=123";
            connection = new SqlConnection(connetionString);
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

            //for(int x=0;x< dtItems.Rows.Count;x++)
            //{
            //    object[] cols = new object[] { "", "" };
            //    cols[0] = dtItems.Rows[x]["FirstName"].ToString();
            //    cols[1] = dtItems.Rows[x]["LastName"].ToString();
            //    dataGridView1.Items.Add(cols);
            //}
            //or
            //dataGridView1.ItemsSource = dt.DefaultView;
        }
        
    
        private void AddEmployee()
        {
            EmployeeRegistrationForm add = new EmployeeRegistrationForm();
             add.Show();    
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
            edt.Show();
     
        }
    }
}
