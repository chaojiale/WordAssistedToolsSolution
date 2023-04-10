using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordAssistedTools.Models {
  public class Consts {
    public static ObservableCollection<double> UpperLimitTimes = new() { 4, 5, 8, 10, 12, 15, 20 };
    public static ObservableCollection<double> FinalReservedTimes = new() { 2, 5, 10, 15, 20, 30, 60 };
    public static ObservableCollection<double> ChangeSlideTimes = new() {0, 0.5, 1, 1.5, 2, 2.5, 3 };
  }
}
