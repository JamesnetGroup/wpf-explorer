using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WpfExplorer.Main.Local.Converters
{
    public class ResourceNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //var dynamic = FrameworkElement.SetResourceReference(targetType as DependencyProperty, value.ToString());
            return Application.Current.FindResource(value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
