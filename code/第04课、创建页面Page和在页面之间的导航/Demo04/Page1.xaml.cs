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

namespace Demo04
{
    /// <summary>
    /// Page1.xaml 的交互逻辑
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 后退
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack == true)
            {
                NavigationService.GoBack();
            }
        }
        /// <summary>
        /// 前进
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoForward == true)
            {
                NavigationService.GoForward();
            }
        }
        /// <summary>
        /// 打开Page2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPage2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Page2.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
