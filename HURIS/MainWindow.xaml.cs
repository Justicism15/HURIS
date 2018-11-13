using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using MaterialDesignColors;
using MaterialDesignThemes.Wpf;


namespace HURIS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection connection;
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlCommand con = new SqlCommand();


        string sql;
        
        string connetionString = null;
        public MainWindow()
        {
            //Initializing and connecting to database.
            InitializeComponent();
            connetionString = "Data Source=JUSTINE-PC;Initial Catalog=SampleDatabase;User ID=justin;Password=123";
            connection = new SqlConnection(connetionString);    
        }

      

        private void Login()
        {
            connection.Open();
            string username = txtUsername.Text.ToString();
            string password = txtPassword.Password.ToString();
            con.Connection = connection;
            
            //Stored Procedures
            SqlCommand cmd = new SqlCommand("usp_EmployeeLogin", connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {
                MessageBox.Show("Login Successful!");
                Dashboard win1 = new Dashboard();
                win1.Show();
                this.Close();
            }
            else if (count > 1)
                MessageBox.Show("Duplicate user name is existing...", "Windows Message", MessageBoxButton.OKCancel);
            else
                MessageBox.Show("Username and password is incorrect", "Windows Message", MessageBoxButton.OKCancel, MessageBoxImage.Stop);

            connection.Close();
        }

        private void ClickButtonEvent(object sender, RoutedEventArgs e)
        {
            if(sender == btnLogin)
            {
                Login();
            }
        }
    }
}
