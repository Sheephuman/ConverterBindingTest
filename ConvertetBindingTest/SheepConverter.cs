using System.Globalization;
using System.Windows.Data;

namespace ConvertetBindingTest
{
    // YourConverter.cs
    public class SheepConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            string result = string.Empty;

            result = values[0].ToString() + values[1].ToString()
                + values[2].ToString();

            return result;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
