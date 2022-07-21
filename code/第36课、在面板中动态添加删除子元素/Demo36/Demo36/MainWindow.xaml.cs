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

namespace Demo36
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

        /// <summary>
        /// 左键点击
        /// 增加方块
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 画布需要有背景色，没有背景色该事件不生效
        private void myCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var mousePosition = e.GetPosition(myCanvas);
            var square = new Rectangle
            {
                Width = 50,
                Height = 50,
                Fill = new SolidColorBrush(Colors.Red),
                Opacity = new Random().NextDouble()
            };

            Canvas.SetLeft(square, mousePosition.X - 25);
            Canvas.SetTop(square, mousePosition.Y - 25);

            /*Grid.SetColumn(square, 1);  //value = 1 -代表第1列
            Grid.SetRow(square, 2);//第二行*/

            myCanvas.Children.Add(square);
        }

        /// <summary>
        /// 右键点击
        /// 删除方块
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void myCanvas_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.Source is UIElement square)
            {
                myCanvas.Children.Remove(square);
            }
        }
    }
}
