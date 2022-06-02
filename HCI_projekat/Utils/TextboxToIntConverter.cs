using System;
using System.Windows.Data;

namespace HCI_projekat.Utils
{
    public class TextboxToIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return string.Empty;
            else if (value is string)
                return value;
            else if (value is int && (int)value == 0)
                return string.Empty;
            else
                return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is string)
            {
                string s = (string)value;
                if (int.TryParse(s, out int _))
                    return System.Convert.ToInt32(s);
                else
                    return 0;
            }
            return value;
        }
    }
}
