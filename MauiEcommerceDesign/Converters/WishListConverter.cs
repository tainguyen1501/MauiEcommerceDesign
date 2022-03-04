using System.Globalization;

namespace MauiEcommerceDesign.Converters
{
    class WishListConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return value;
            var result = string.Empty;

            if (value is bool boolValue)
            {
                try
                {
                    result = boolValue ? "wishlist_checked_ic.png" : "wishlist_ic.png";
                }
                finally
                {
                }
            }

            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
