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
using System.Data.SqlClient;
namespace WpfAppLearn
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window //繼承Window/Page
    {
        SqlConnection con = new SqlConnection(@"Data Source = 192.168.1.103; Initial Catalog = CourseApp; User=sme322;Password=Sme322820827");
        
        public MainWindow()
        {
            InitializeComponent();

            this.btn1.Width = 200;
            this.btn1.Height = 300;
            
          //  con.Open();

        }

        private void Button_Click(object sender, RoutedEventArgs e)//事件處理常式，sender->Object引發事件的對象
        {
            MessageBox.Show("Hello WPF");

        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello WPF2");
            

        }

    }
}
