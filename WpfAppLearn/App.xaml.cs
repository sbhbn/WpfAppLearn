using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppLearn
{

    /// <summary>
    /// App.xaml 的互動邏輯
    /// </summary>
    public partial class App : Application
    {

      

        public void Application_Startup(object sender, StartupEventArgs e)
        {
            var window = new Window1();
            window.Show();

            var window2 = new Window2();
            window2.Show();
        }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)//EventArgs事件的資訊
        {
            e.Exception.Message.ToString();//簡要資訊
            e.Exception.ToString();//Exception StackTrace
            MessageBox.Show("系統發生異常，請洽系統管理者", "Unhandled Exception", MessageBoxButton.OK, MessageBoxImage.Error);
            e.Handled = true;//錯誤別再延伸

        }
        private void Application_Exit(object sender, ExitEventArgs e) {

            if (e.ApplicationExitCode == 0)
            {
                MessageBox.Show($"應用程式正常關閉");
            }
            else {
                MessageBox.Show($"應用程式異常關閉");
            }
        }
        
    }
}
