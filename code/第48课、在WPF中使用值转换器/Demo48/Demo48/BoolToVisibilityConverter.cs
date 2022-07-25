using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Demo48
{
    public class BoolToVisibilityConverter : IValueConverter
    {
        //从源转换到目标
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            /* //xaml不加参数ConverterParameter=inverse
             //判断value是否为布尔值，并定义变量
             return value is bool val && val ? Visibility.Visible : Visibility.Collapsed;*/

            //加参数 ConverterParameter=inverse--（自定义变量：相反的）
            var val = (bool)value;
            //判断参数
            if (parameter is string param && param == "inverse")
            {
                //取反
                val = !val;
            }
            return val ? Visibility.Visible : Visibility.Collapsed;
        }

        //从目标转换回来
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
