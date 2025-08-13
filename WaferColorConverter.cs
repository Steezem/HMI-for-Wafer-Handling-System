using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace HMI_for_Wafer_Handling_System.Views;

[ValueConversion(typeof(bool), typeof(Brush))]
public class WaferColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
        return value is bool present && present ? Brushes.Blue : Brushes.Gray;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        //not necessary since only transfer from LP1 to LP2 is done
        => throw new NotImplementedException();
}