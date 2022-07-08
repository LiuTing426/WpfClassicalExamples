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

namespace Demo19
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

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            pb1.Value += 10;
            pb2.Value += 10;
        }

        private void Reduce_click(object sender, RoutedEventArgs e)
        {
            pb1.Value -= 10;
            pb2.Value -= 10;
        }

        private void Start_click(object sender, RoutedEventArgs e)
        {
            pb3.IsIndeterminate = true;
        }

        private void Stop_click(object sender, RoutedEventArgs e)
        {
            pb3.IsIndeterminate = false;
            pb3.Value = 100;
        }
    }
}
