using Microsoft.Win32;
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

namespace Demo05
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
        /// 打开自定义WinDialog对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowWinDlg_Click(object sender, RoutedEventArgs e)
        {
            WinDialog winDialog = new WinDialog();
            winDialog.ShowDialog();
            lb_DialogResult.Items.Add(winDialog.DialogResult);
        }


        /// <summary>
        /// 打开文件对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFileDlg_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                lb_DialogResult.Items.Add(openFileDialog.FileName);
            }
        }


        /// <summary>
        /// 打开保存对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenAndSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                lb_DialogResult.Items.Add(saveFileDialog.FileName);
            }
        }

        /// <summary>
        /// 打印对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenPrint_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                lb_DialogResult.Items.Add("打印已选择");
            }
        }


        /// <summary>
        /// 打开字体对话框 ***需要添加 Winform引用 =- System.Windows.Forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFont_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FontDialog fontDialog = new System.Windows.Forms.FontDialog();
            if (fontDialog.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                lb_DialogResult.Items.Add("字体已选择");
            }
        }


        /// <summary>
        /// 打开颜色对话框 也是引用Forms 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenColor_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.ColorDialog colorDialog = new System.Windows.Forms.ColorDialog();
            if (colorDialog.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                lb_DialogResult.Items.Add("颜色已选择");
            }
        }
    }
}
