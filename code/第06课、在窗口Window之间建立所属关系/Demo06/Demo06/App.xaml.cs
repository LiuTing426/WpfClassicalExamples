using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Demo06
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        //重写
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            //实例化
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            ToolBox toolBox = new ToolBox();
            //设置所属关系
            toolBox.Owner = mainWindow;
            toolBox.Show();
        }
    }
}
