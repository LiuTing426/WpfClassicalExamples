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

namespace Demo46
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
                new Employee{Id="1",FirstName="F001",LastName="L001",Department="D001"},
                new Employee{Id="2",FirstName="F002",LastName="L002",Department="D002"},
                new Employee{Id="3",FirstName="F003",LastName="L003",Department="D003"},
                new Employee{Id="4",FirstName="F004",LastName="L004",Department="D001"},
                new Employee{Id="5",FirstName="F005",LastName="L005",Department="D002"}
            };
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

        /// <summary>
        /// 筛选
        /// 文本框改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var cvs = CollectionViewSource.GetDefaultView(dataGrid.ItemsSource);
            //CanFilter 是否可以筛选 -- 修补-- 生成方法
            if (cvs != null && cvs.CanFilter)
            {
                //OnFilterApplied 自定义名称设置筛选方式 -- 生成方法！！！
                cvs.Filter = OnFilterApplied;

            }
        }
        private bool OnFilterApplied(object obj)
        {
            if (obj is Employee emp)
            {
                var searchText = searchBox.Text.ToLower();
                //筛选部门/等等
                return emp.Department.ToLower().Contains(searchText)
                    || emp.FirstName.ToLower().Contains(searchText)
                    || emp.LastName.ToLower().Contains(searchText)
                    || emp.Id.ToLower().Contains(searchText);
            }
            return false;
        }
    }
}
