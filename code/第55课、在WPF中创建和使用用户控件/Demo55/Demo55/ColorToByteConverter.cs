using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Demo55
{
    public class ColorToByteConverter : IValueConverter
    {
        Color oldColor;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Color color && parameter is string parameterValue)
            {
                oldColor = color;
                switch (parameterValue)
                {
                    case "r":
                        return color.R;
                    case "g":
                        return color.G;
                    case "b":
                        return color.B;
                    default:
                        return color.A;
                }
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color color = oldColor;
            byte colorValue = System.Convert.ToByte(value);

            if (parameter is string parameterValue)
            {
                switch (parameterValue)
                {
                    case "r":
                        color.R = colorValue;
                        break;
                    case "g":
                        color.G = colorValue;
                        break;
                    case "b":
                        color.B = colorValue;
                        break;
                    default:
                        color.A = colorValue;
                        break;
                }
            }
            oldColor = color;
            return color;
        }
    }
}
