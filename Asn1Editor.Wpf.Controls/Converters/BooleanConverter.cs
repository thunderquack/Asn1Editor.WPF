using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;

namespace SysadminsLV.Asn1Editor.Controls.Converters
{
    /// <summary>
    /// Provides a mechanism to convert a <see langword="bool"/> value to a specified type and back.
    /// </summary>
    /// <remarks>This class allows mapping <see langword="true"/> and <see langword="false"/> values to custom
    /// values of type <typeparamref name="T"/>. It is commonly used in scenarios such as data binding, where boolean
    /// values need to be represented as other types (e.g., strings, colors, or other domain-specific values).</remarks>
    /// <typeparam name="T">The type to which <see langword="bool"/> values are converted.</typeparam>
    public class BooleanConverter<T> : IValueConverter
    {
        public BooleanConverter(T trueValue, T falseValue)
        {
            True = trueValue;
            False = falseValue;
        }

        /// <summary>
        /// Gets or sets the value representing the "true" state for the current context.
        /// </summary>
        public T True { get; set; }

        /// <summary>
        /// Gets or sets the value representing the "false" state for the current context.
        /// </summary>
        public T False { get; set; }

        public virtual object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is bool && ((bool)value) ? True : False;
        }

        public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is T && EqualityComparer<T>.Default.Equals((T)value, True);
        }
    }
}