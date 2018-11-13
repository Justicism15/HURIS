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

namespace HURIS
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnLogout(object sender, RoutedEventArgs e)
        {
            MainWindow win1 = new MainWindow();
            win1.Show();
            this.Close();
        }

        private void btnEmployees(object sender, MouseButtonEventArgs e)
        {
            //Content.Content = new Employees();
            Content.Navigate(new Test123());
            //Sample samp = new Sample();
            //samp.Show();
        }

        private void btnDashboard(object sender, MouseButtonEventArgs e)
        {
            Content.Content = new DashboardContent();
          
        }

        private void btnSettings(object sender, MouseButtonEventArgs e)
        {
            Content.Content = new Settings();
        }

        private void btnPayroll(object sender, MouseButtonEventArgs e)
        {
            Content.Content = new PayrollManagement();
        }

        private void btnDepartment(object sender, MouseButtonEventArgs e)
        {
            Content.Content = new Department();
        }

        private void btnLeaves(object sender, MouseButtonEventArgs e)
        {
            Content.Content = new Leaves();
        }

        private void btnAttendance(object sender, MouseButtonEventArgs e)
        {
            Content.Content = new Attendance();
        }
    }
}
