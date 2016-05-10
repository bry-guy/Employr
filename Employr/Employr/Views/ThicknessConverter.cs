using System;
using System.Globalization;
using Xamarin.Forms;

namespace Employr.Views
{
    public class ThicknessConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int index = 0;
            double val = (double) value;

            if (parameter != null)
                index = (int) parameter;

            switch (index)
            {
                case 0:
                    return new Thickness(val,0,0,0);
                case 1:
                    return new Thickness(0, val, 0, 0);
                case 2:
                    return new Thickness(0, 0, val, 0);
                case 3:
                    return new Thickness(0, 0, 0, val);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}