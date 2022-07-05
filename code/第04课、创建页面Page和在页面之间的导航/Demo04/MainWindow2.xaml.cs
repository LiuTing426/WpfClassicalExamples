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

namespace Demo04
{
    /// <summary>
    /// Main_Window2.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow2 : Window
    {
        public MainWindow2()
        {
            InitializeComponent();
        }

        private void btnPage1_click(object sender, RoutedEventArgs e)
        {
            this.FrameA.Source = new Uri("Page1.xaml", UriKind.RelativeOrAbsolute);
        }

        private void btnPage2_click(object sender, RoutedEventArgs e)
        {
            this.FrameA.Source = new Uri("Page2.xaml", UriKind.RelativeOrAbsolute);
        }

        private void btnPage3_click(object sender, RoutedEventArgs e)
        {
            this.FrameA.Source = new Uri("Page3.xaml", UriKind.RelativeOrAbsolute);
        }
    }
}
