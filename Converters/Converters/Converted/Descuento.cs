using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Converters.Converted
{
    public class Descuento : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if (value.ToString() == "")
                {
                    return 0;
                }
                else
                {
                    int precio = int.Parse(value.ToString());
                    float preciodescuento = precio * 50 / 100;
                    return preciodescuento;
                }
            }
            else
            {
                return 0;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
