using System;
using System.Globalization;
using System.Windows.Data;

namespace SysadminsLV.Asn1Editor.Controls.Converters
{
    public class MoveTabHeaderConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is ActivePanel panel
                ? (panel == ActivePanel.Left ? "Move Right" : "Move Left")
                : "Move";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}