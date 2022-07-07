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

namespace Demo13
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //手动添加图片
            //方法1：缺点：需更改图片属性，并且和xaml的相同图片冲突，需要复制2份图片
            //imageA.Source = new ImageSourceConverter().ConvertFromString("picture2.jpg") as ImageSource;

            //****   右键图片文件》》属性》》高级 -- 复制到输出目录：不复制 改为 始终复制 且 生成操作：Resource 改为 无


            //方法2：优点：不需要设置图片属性！！！
            imageA.Source = new BitmapImage(new Uri("picture1.jpg", UriKind.RelativeOrAbsolute));
        }
    }
}
