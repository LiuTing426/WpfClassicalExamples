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

namespace Demo68
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            //获取WPF 的资源数据文件的资源流
            //var streamResourceInfo = Application.GetResourceStream(new Uri("Images/pic1.jpg",UriKind.RelativeOrAbsolute));
            
            //引用ClassLibrary1后
            var streamResourceInfo = Application.GetResourceStream(new Uri("/ClassLibrary1;component/Images/pic2.jpg", UriKind.RelativeOrAbsolute));

            var bitmapImage = new BitmapImage();

            //开始初始化
            bitmapImage.BeginInit();
            //缓存选项
            bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
            bitmapImage.StreamSource = streamResourceInfo.Stream;

            //结束初始化
            bitmapImage.EndInit();
            
            //冻结
            bitmapImage.Freeze();

            imageTest.Source = bitmapImage;
        }
    }
}
