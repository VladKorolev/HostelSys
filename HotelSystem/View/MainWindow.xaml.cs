using System;
using System.Windows;
using HotelSystem.Model;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Data.SqlClient;
namespace HotelSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();

        public MainWindow()
        {
            InitializeComponent();
            RoomTypeCb.ItemsSource = RtCbFilter.ItemsSource = Enum.GetNames(typeof(RoomTypes));
            
            
            con.ConnectionString = Properties.Settings.Default.con;
            com.Connection = con;
            try { con.Open(); }
            catch
            {
                MessageBox.Show("Нет соединения");
                Close(); con.Close(); return;
            }
            finally
            {
                MessageBox.Show("База данных подключена");
            }
        }
        private void NumberValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.-]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
   
}