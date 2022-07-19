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

namespace Demo21
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

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            //①单选  SelectionMode="SingleDate"
            // MessageBox.Show("你选择了" +e.AddedItems[0].ToString());

            //②多选 SelectionMode="SingleRange"
            /*string myDates = "";
            foreach (var item in e.AddedItems)
            {
                myDates += item.ToString() + Environment.NewLine;
            }
            MessageBox.Show("你选择了" + myDates);*/

            //③多选  SelectionMode="MultipleRange"
            //调试发现e存在的内容不准确，sender准确，但是sender时object，需要转换为Calendar
            Calendar calendar = sender as Calendar;
            if (calendar == null)
            {
                return;
            }
            else
            {
                string myDates = "";
                foreach (var item in calendar.SelectedDates)
                {
                    myDates += item.ToString() + Environment.NewLine;
                }
                tb.Text = "你选择了" + myDates;
            }
        }
    }
}
