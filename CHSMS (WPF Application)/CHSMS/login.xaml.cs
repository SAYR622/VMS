using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace CHSMS
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    conn.Open();

                    // FIXED: Changed to MessageBoxButton and MessageBoxImage
                    MessageBox.Show("Connection to the database was successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                    // Put your SELECT query and password checking logic here!
                }
                catch (Exception ex)
                {
                    // FIXED: Changed to MessageBoxButton and MessageBoxImage
                    MessageBox.Show("Database connection error: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}