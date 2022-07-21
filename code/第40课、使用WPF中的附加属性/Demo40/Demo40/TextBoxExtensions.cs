using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Demo40
{
    /// <summary>
    /// 光标点击后 按Tab键切换 第二个TextBox选中全内容
    /// </summary>
    class TextBoxExtensions
    {
        //propa
        public static bool GetSelectOnFocus(DependencyObject obj)
        {
            return (bool)obj.GetValue(SelectOnFocusProperty);
        }

        public static void SetSelectOnFocus(DependencyObject obj, bool value)
        {
            obj.SetValue(SelectOnFocusProperty, value);
        }

        // Using a DependencyProperty as the backing store for SelectOnFocus.  This enables animation, styling, binding, etc...

        // new PropertyMetadata --OnSelectOnFocsChanged - 增加 属性改变的回调函数,生成方法
        public static readonly DependencyProperty SelectOnFocusProperty =
            DependencyProperty.RegisterAttached("SelectOnFocus", typeof(bool), typeof(TextBoxExtensions), 
                new PropertyMetadata(false,OnSelectOnFocsChanged));

        private static void OnSelectOnFocsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is TextBox textBox)
            {
                //获得焦点
                textBox.GotFocus += (s, args) =>
                {
                    textBox.SelectAll();
                };
            }
        }
    }
}
