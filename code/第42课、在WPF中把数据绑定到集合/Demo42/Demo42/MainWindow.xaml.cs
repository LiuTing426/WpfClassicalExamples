using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Demo42
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Employees = new ObservableCollection<Employee>
            {
                //按下Alt 拖动鼠标 可以实现很多行选中
                new Employee{FirstName="张",LastName="1",Department="Department_1"},
                new Employee{FirstName="张",LastName="2",Department="Department_2"},
                new Employee{FirstName="张",LastName="3",Department="Department_3"},
                new Employee{FirstName="张",LastName="4",Department="Department_4"},
                new Employee{FirstName="张",LastName="5",Department="Department_5"},
                new Employee{FirstName="张",LastName="6",Department="Department_6"}
            };

            //替代 Xaml的ItemSource数据绑定
            dataGrid.ItemsSource = Employees;
        }

        //依赖项属性 propdp


        public ObservableCollection<Employee> Employees
        {
            get { return (ObservableCollection<Employee>)GetValue(EmployeesProperty); }
            set { SetValue(EmployeesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Employees.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EmployeesProperty =
            DependencyProperty.Register("Employees", typeof(ObservableCollection<Employee>), typeof(MainWindow), new PropertyMetadata(null));

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //断点可以查看出 从界面修改后 后台数据是发生变化的！
            ;
        }
    }
}
