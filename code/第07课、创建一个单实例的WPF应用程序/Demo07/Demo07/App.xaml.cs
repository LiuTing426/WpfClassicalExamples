using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Demo07
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {


        //重写启动函数
        //目的：在文件夹 bin/Debug中点击程序 只出现第一个程序 后面报程序已启动
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            //自己加
            Mutex mutex = new Mutex(true, "单实例程序", out bool isNewInstance);
            //判断 如果互斥体已经存在 返回false
            if (isNewInstance != true)
            {
                //MessageBox.Show("程序已启动");

                //目的 双击程序的时候，使得本来打开的程序出现在屏幕上 
                IntPtr intPtr = FindWindowW(null, "单实例应用程序");
                if (intPtr != IntPtr.Zero)
                {
                    SetForegroundWindow(intPtr);
                }
                //程序退出
                Shutdown();
            }
        }


        //目的 双击程序的时候，使得本来打开的程序出现在屏幕上 
        // FindWindowW 按F1 跳进function文档，复制Syntax如下 下滑找到Dll

        /*HWND FindWindowW( [in, optional] LPCWSTR lpClassName,
                            [in, optional] LPCWSTR lpWindowName );
        */

        [DllImport("User32", CharSet = CharSet.Unicode)]
        static extern IntPtr FindWindowW(String lpClassName, String lpWindowName);


        //同理
        //SetForegroundWindow

        /*BOOl SetForeGroundWindow(HWND hWnd);*/
        [DllImport("User32", CharSet = CharSet.Unicode)]
        static extern Boolean SetForegroundWindow(IntPtr hWnd);
    }
}
