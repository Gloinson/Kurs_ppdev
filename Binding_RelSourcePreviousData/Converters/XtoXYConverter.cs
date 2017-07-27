using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Binding_RelSourcePreviousData.Converters
{
    internal class XtoPointConverter : IMultiValueConverter
    {
        public object Convert(object[] value, Type targetType, object parameter, CultureInfo culture)
        {
            int xval = (int)value[0] * (int)(double)value[1];

            int yval = 0;
            if (value[2] is int)
                yval = (int) value[2];

            return new Point(yval, xval);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    internal class XtoXYConverter : IMultiValueConverter
    {
        public object Convert(object[] value, Type targetType, object parameter, CultureInfo culture)
        {
            int xval = (int)value[0] * (int)(double)value[1];

            int yval = 0;
            if (value[2] is int)
                yval = (int)value[2];

            return $"{yval}, {xval}";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
