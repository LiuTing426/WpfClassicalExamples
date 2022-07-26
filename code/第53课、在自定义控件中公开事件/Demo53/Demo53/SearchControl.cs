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

namespace Demo53
{
    /// <summary>
    /// 按照步骤 1a 或 1b 操作，然后执行步骤 2 以在 XAML 文件中使用此自定义控件。
    ///
    /// 步骤 1a) 在当前项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根
    /// 元素中:
    ///
    ///     xmlns:MyNamespace="clr-namespace:Demo53"
    ///
    ///
    /// 步骤 1b) 在其他项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根
    /// 元素中:
    ///
    ///     xmlns:MyNamespace="clr-namespace:Demo53;assembly=Demo53"
    ///
    /// 您还需要添加一个从 XAML 文件所在的项目到此项目的项目引用，
    /// 并重新生成以避免编译错误:
    ///
    ///     在解决方案资源管理器中右击目标项目，然后依次单击
    ///     “添加引用”->“项目”->[浏览查找并选择此项目]
    ///
    ///
    /// 步骤 2)
    /// 继续操作并在 XAML 文件中使用控件。
    ///
    ///     <MyNamespace:SearchControl/>
    ///
    /// </summary>
    public class SearchControl : Control
    {
        static SearchControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SearchControl), new FrameworkPropertyMetadata(typeof(SearchControl)));
        }


        //依赖属性
        public string SearchTerm
        {
            get { return (string)GetValue(SearchTermProperty); }
            set { SetValue(SearchTermProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SearchTerm.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SearchTermProperty =
            DependencyProperty.Register("SearchTerm", typeof(string), typeof(SearchControl), new PropertyMetadata(""));


        //创建SearchEventArgs.cs 继承EventArgs
        //定义委托
        public delegate void OnSearchClick(object sender, SearchEventArgs e);
        //按钮点击事件
        public event OnSearchClick SearchButtonClick;
        //重写OnApplyTemplate函数
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            if (GetTemplateChild("PART_Button") is Button button)
            {
                button.Click += Button_Click;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SearchButtonClick?.Invoke(this, new SearchEventArgs { SearchTerm = SearchTerm });
        }

        //修改Generic.xaml的TextBox的Text的绑定内容
    }
}
