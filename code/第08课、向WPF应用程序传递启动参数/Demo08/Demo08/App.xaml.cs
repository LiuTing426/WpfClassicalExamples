using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Demo08
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            //StartupEventArgs ->启动事件参数
            var arg = e.Args;
            if (arg.Contains("/Window1"))
            {
                //右键 Demo08 --> 属性 -->调试 -->命令行参数 -->写入 /Window1 就会启动Window1
                new Window1().Show();
            }
            else
            {
                new MainWindow().Show();
            }
        }
    }
}
