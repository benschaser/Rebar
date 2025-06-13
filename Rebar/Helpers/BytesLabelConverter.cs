using System.Globalization;
using System.Windows.Data;
using Wpf.Ui.Appearance;

namespace Rebar.Helpers
{
    internal class BytesLabelConverter : IValueConverter
    {
        private static readonly string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB" };
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || !double.TryParse(value.ToString(), out double size))
                return "0 bytes";

            int suffixIndex = 0;
            while (size >= 1024 && suffixIndex < SizeSuffixes.Length - 1)
            {
                size /= 1024;
                suffixIndex++;
            }

            return string.Format(culture, "{0:N2} {1}", size, SizeSuffixes[suffixIndex]);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
