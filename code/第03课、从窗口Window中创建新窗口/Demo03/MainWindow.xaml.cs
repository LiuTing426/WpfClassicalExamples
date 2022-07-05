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

namespace Demo03
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //实例化window1
        Window1 win;
        private void ButtonOpen_Click(object sender, RoutedEventArgs e)
        {
            //实例化window1
            //var win = new Window1();
            win = new Window1();
            //打开第2个窗口后，第1个窗口可以先关闭，留第2个窗口展示，并且可以打开多个窗口2
            win.Show();

            //必须要关闭第2个窗口后，才能点击第1个窗口，并且不能打开多个窗口2
            //win.ShowDialog();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            win.Close();
        }

        private void ButtonHide_Click(object sender, RoutedEventArgs e)
        {
            win.Hide();
        }

        private void ButtonShow_Click(object sender, RoutedEventArgs e)
        {
            win.Show();
        }

        //***********窗口2隐藏 关闭窗口1后 程序是没有停止的 
        //***********窗口2关闭 关闭窗口1后 程序是停止的
    }
}
