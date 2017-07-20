using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace MultiConverters.Converts
{
    class RgbToBrushConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if(values.Length>3) {
                try
                {
                    var h = (byte)(double)values[0];
                    var r = (byte)(double)values[1];
                    var g = (byte)(double)values[2];
                    var b = (byte)(double)values[3];
                    return new SolidColorBrush(Color.FromArgb(h, r, g, b));
                }
                catch(System.InvalidCastException)
                {
                }
            }
            return new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            if(value is SolidColorBrush x) {
                return new object[] { (double)x.Color.A, (double)x.Color.R, (double)x.Color.G, (double)x.Color.B };
            }
            return new object[] { 0, 0, 0 };
        }
    }

    class RgbToASCIIConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var r = (byte)(double)values[0];
            var g = (byte)(double)values[1];
            var b = (byte)(double)values[2];

            return String.Format($"{r:X}{g:X}{b:X}");
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
