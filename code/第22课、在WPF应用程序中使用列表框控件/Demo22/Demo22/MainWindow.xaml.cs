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

namespace Demo22
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
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        int index = 10;
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            index++;
            lb.Items.Add(new ListBoxItem() { Content = "选项：" + index });
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //①单选 SelectionMode="Single"
            //lb.Items.Remove(lb.SelectedItem);

            //②多选 SelectionMode="Multiple"
            //直接循环删除 会报错 - 建议全部取出来再删除
            List<object> items = new List<object>();
            foreach (var item in lb.SelectedItems)
            {
                items.Add(item);
            }
            foreach (var item in items)
            {
                lb.Items.Remove(item);
            }

            //③ 扩展多选 SelectionMode="Extended" 用的多！！！！ Shift / Ctrl
        }
    }
}
