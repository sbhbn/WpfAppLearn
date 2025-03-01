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
using System.Data.SqlClient;
using System.Data;

namespace WpfAppLearn
{
    /// <summary>
    /// Window1.xaml 的互動邏輯
    /// </summary>
    public partial class Window1 : Window
    {
        string connectionString = "Data Source=DESKTOP-2AN95UG\\SQLEXPRESS;Initial Catalog=CourseApp;User ID=sme322;Password=Sme322820827";

        public Window1()
        {
            InitializeComponent();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("✅ 成功連線到 SQL Server!");

                    // 定義 SQL 查詢
                    string query = "SELECT * from books where id='E6806C98-82C0-486F-A361-13DECCC0D103'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            Console.WriteLine("📌 查詢結果：");
                            while (reader.Read())
                            {
                                // 根據實際的 SQL Server 型別來做適當轉換
                                Guid id = reader.GetGuid(0); // 如果 `Id` 是 `BIGINT`
                                string name = reader.IsDBNull(1) ? "N/A" : reader.GetString(1);
                                int price = reader.IsDBNull(2) ? 0 : reader.GetInt32(2); // 如果 是 `DECIMAL`

                                Console.WriteLine($"ID: {id}, 書名: {name}, 價格: {price}");
                                this.ShowInfo.Text = "編號:"+id;
                                this.ShowInfo1.Text = name;
                                this.ShowInfo2.Text = "價格:"+price;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ 連線失敗: " + ex.Message);
            }



            ///  int i = 0;
            //  int j= 1;
            //   int k = j / i;
           


        }
    
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello WPF3!");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Button b1 = new Button();
            b1.Content = "Click Me!";

         
            b1.Width = 100;
            b1.Height = 30;
            b1.Margin = new Thickness(100, 150, 0, 0);
            b1.Click += B1_Click;//訂閱事件

        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hi there!");
         
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hi there!");
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult Key = MessageBox.Show("確定真的要離開?","確認",MessageBoxButton.YesNo,MessageBoxImage.Question,MessageBoxResult.No);
            e.Cancel = (Key == MessageBoxResult.No);


        }
        


    }
}
