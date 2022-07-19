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

namespace Demo25
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
        /// 黑体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //三步运算-如果是黑体改为正常，如果不是黑体改为黑体
            text.FontWeight =
                text.FontWeight == FontWeights.Bold ?
                FontWeights.Normal : FontWeights.Bold;
        }
        /// <summary>
        /// 斜体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            text.FontStyle =
                text.FontStyle == FontStyles.Italic ?
                FontStyles.Normal : FontStyles.Italic;
        }
        /// <summary>
        /// 下划线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            text.TextDecorations =
                text.TextDecorations == TextDecorations.Underline ?
                null : TextDecorations.Underline;
        }
        /// <summary>
        /// 字号 选择改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (text == null)
            {
                return;
            }

            ComboBox comboBox = sender as ComboBox;
            if (comboBox == null)
            {
                return;
            }

            ComboBoxItem comboBoxItem = comboBox.SelectedValue as ComboBoxItem;
            if (comboBoxItem == null)
            {
                return;
            }

            text.FontSize = int.Parse(comboBoxItem.Content.ToString());
        }

    }
}
