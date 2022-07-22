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

namespace Demo44
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
                new Employee{Id="4",FirstName="F004",LastName="L004",Department="D004"},
                new Employee{Id="5",FirstName="F005",LastName="L005",Department="D005"}
            };
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

        private void sort_Click(object sender, RoutedEventArgs e)
        {
            var cvs = CollectionViewSource.GetDefaultView(dataGrid.ItemsSource);
            
            //是否支持排序 并且不为空
            if (cvs != null && cvs.CanSort)
            {
                //清空之前的排序 
                cvs.SortDescriptions.Clear();
                //选中后排序 
                if (sort.IsChecked == true)
                {
                    cvs.SortDescriptions.Add(new System.ComponentModel.SortDescription(
                        "Department",
                        System.ComponentModel.ListSortDirection.Descending));
                }
            }
        }
    }
}
