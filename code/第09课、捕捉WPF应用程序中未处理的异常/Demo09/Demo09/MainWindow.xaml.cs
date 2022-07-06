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

namespace Demo09
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //添加事件 可忽略 此处处理异常记录日志不是最优选择！！！还是要在App.xaml.cs中处理！！！
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }

        //可忽略
        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            //throw new NotImplementedException();
            MessageBox.Show("CurrentDomain_UnhandledException, 异常已处理！");
            //e.Handled = true;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (rd_0.IsChecked == true)
            {
                try
                {
                    throw new Exception("引发异常");
                }
                catch (Exception)
                {
                    MessageBox.Show("捕捉异常");
                }
            }
            if (rd_1.IsChecked == true)
            {
                throw new Exception("引发异常");
            }

        }
    }
}
