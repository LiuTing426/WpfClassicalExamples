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

namespace Demo56
{
    /// <summary>
    /// ColorMixer.xaml 的交互逻辑
    /// </summary>
    public partial class ColorMixer : UserControl
    {
        public ColorMixer()
        {
            InitializeComponent();
        }
        //propdp
        public Color SelectedColor
        {
            get { return (Color)GetValue(SelectedColorProperty); }
            set { SetValue(SelectedColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedColor.  This enables animation, styling, binding, etc...

        //SelectedColor 的初始颜色为DarkBlue
        public static readonly DependencyProperty SelectedColorProperty =
            DependencyProperty.Register("SelectedColor", typeof(Color), typeof(ColorMixer), new PropertyMetadata(Colors.DarkBlue));

        //定义委托
        public delegate void OnOKClick(object sender, EventArgs e);
        public delegate void OnCancelClick(object sender, EventArgs e);

        //定义事件
        public event OnOKClick OnOkButtonClick;
        public event OnCancelClick OnCancelButtonClick;

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            //判断OnOkButtonClick是否赋值，如果赋值调用sender、、
            OnOkButtonClick?.Invoke(sender, e);
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            OnCancelButtonClick?.Invoke(sender, e);
        }

        //以上后 在MainWindow就可以加事件-OnOkButtonClick和OnCancelButtonClick
    }
}
