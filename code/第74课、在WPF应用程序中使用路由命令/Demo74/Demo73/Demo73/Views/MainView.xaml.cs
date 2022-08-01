using Demo73.ViewModels;
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
using System.Windows.Shapes;

namespace Demo73.Views
{
    /// <summary>
    /// MainView.xaml 的交互逻辑
    /// </summary>
    public partial class MainView : Window
    {
        private MainViewModel ViewModel = null;

        public MainView()
        {
            InitializeComponent();
            ViewModel = Resources["ViewModel"] as MainViewModel;
            if (ViewModel == null)
            {
                throw new NullReferenceException("ViewModel 不可以为空！");
            }
        }

        //FirstName和LastName同时不为空 按钮才是启用状态
        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (ViewModel!=null)
            {
                var userDetail = ViewModel.NewUserDetail;
                //是否为空或者空白
                e.CanExecute =
                    !string.IsNullOrWhiteSpace(userDetail.FirstName)
                    &&
                    !string.IsNullOrWhiteSpace(userDetail.LastName);
            }
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ViewModel.UserCollection.Add(ViewModel.NewUserDetail);
            ViewModel.SelectedUser = ViewModel.NewUserDetail;

            //NewUserDetail清空
            ViewModel.NewUserDetail = new Models.MainModel();
        }
    }
}
