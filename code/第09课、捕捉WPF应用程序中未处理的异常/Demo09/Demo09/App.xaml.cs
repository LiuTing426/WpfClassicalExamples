using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Demo09
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            //添加 DispatcherUnhandledException +=后Tab键，点应用
            DispatcherUnhandledException += App_DispatcherUnhandledException;
        }
        // 处理程序中所有的异常
        private void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            //***************
            //不知道发生什么异常的时候，如果不解决异常可能会导致程序崩溃，
            //可以在App.xaml.cs中解决
            //记录日志，记录发生什么异常
            //如果程序关键或者是内部逻辑错误可以在此处重启程序

            //throw new NotImplementedException();
            MessageBox.Show("DispatcherUnhandledException, 异常已处理！");

            //在e.Handled之前记录日志等 
            e.Handled = true;
        }



    }
}
