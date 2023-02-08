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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Data.Linq;
using WpfApp4.ConsoleApp11;


namespace WpfApp4
{

    public partial class MainWindow : Window
    {

        string connectionString = @"Data Source = HOME-PC; Initial Catalog = adonetdb; Trusted_Connection=True;TrustServerCertificate = True ";

        string sql = "SELECT * FROM Users";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            but1.Visibility = Visibility.Hidden;
            but2.Visibility = Visibility.Hidden;
            but3.Visibility = Visibility.Visible;
            but2_Copy1.Visibility = Visibility.Visible;
            text1.Visibility = Visibility.Visible;
            text2.Visibility = Visibility.Visible;
            text3.Visibility = Visibility.Visible;
        }

        private void but3_Click(object sender, RoutedEventArgs e)
        {
            but1.Visibility = Visibility.Visible;
            but2.Visibility = Visibility.Visible;
            but3.Visibility = Visibility.Hidden;
            but2_Copy1.Visibility = Visibility.Hidden;
            text1.Visibility = Visibility.Hidden;
            text2.Visibility = Visibility.Hidden;
            text3.Visibility = Visibility.Hidden;
        }

        private void but1_Click(object sender, RoutedEventArgs e)
        {
            but1.Visibility = Visibility.Hidden;
            but2.Visibility = Visibility.Hidden;
            but3.Visibility = Visibility.Visible;
            but2_Copy1.Visibility = Visibility.Visible;
            text1.Visibility = Visibility.Visible;
            text2.Visibility = Visibility.Visible;
            text3.Visibility = Visibility.Visible;
            

            
        }

        private void text1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            text1.Text = string.Empty;
        }


        private void text3_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            text3.Text = string.Empty;
        }

        private void text2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            text2.Text = string.Empty;
        }

        private async void but2_Copy1_Click(object sender, RoutedEventArgs e)
        {
            int num;
            DataContext db = new DataContext(connectionString);

            var user1 = db.GetTable<Users>().OrderByDescending(u => u.Id).FirstOrDefault();
            Users user2 = db.GetTable<Users>().FirstOrDefault();

            user2.Age = 40;
            db.SubmitChanges();
            but1.Visibility = Visibility.Visible;
            but2.Visibility = Visibility.Visible;
            but3.Visibility = Visibility.Hidden;
            but2_Copy1.Visibility = Visibility.Hidden;
            text1.Visibility = Visibility.Hidden;
            text2.Visibility = Visibility.Hidden;
            text3.Visibility = Visibility.Hidden;
        }

    }
}
