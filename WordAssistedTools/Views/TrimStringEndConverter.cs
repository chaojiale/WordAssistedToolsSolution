using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WordAssistedTools.Views {
  public class TrimStringEndConverter:IValueConverter {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
      return value is string s ? s.TrimEnd() : null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
      return null;
    }
  }
}
