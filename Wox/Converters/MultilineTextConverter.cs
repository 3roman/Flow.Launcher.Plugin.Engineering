using System;
using System.Globalization;
using System.Windows.Data;

namespace Wox.Converters
{
    class MultilineTextConverter : IValueConverter
    {
        /// <inheritdoc />
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value as string)?.Replace("\n", "\u2007") ?? string.Empty;
        }

        /// <inheritdoc />
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value as string)?.Replace("\u2007", "\n") ?? string.Empty;
        }
    }
}
