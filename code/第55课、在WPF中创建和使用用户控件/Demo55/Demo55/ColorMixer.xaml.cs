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

namespace Demo55
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
    }
}
