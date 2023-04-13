using Prism.Mvvm;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WordAssistedTools.Models;
using WordAssistedTools.Properties;
using WordAssistedTools.Utils;

namespace WordAssistedTools.ViewModels {
  internal class UserSettingsViewModel : BindableBase {
    private double _selectedUpperLimitTime = Consts.UpperLimitTimes[1];
    public double SelectedUpperLimitTime {
      get => _selectedUpperLimitTime;
      set => SetProperty(ref _selectedUpperLimitTime, value);
    }

    private double _selectedFinalReservedTime = Consts.FinalReservedTimes[1];
    public double SelectedFinalReservedTime {
      get => _selectedFinalReservedTime;
      set => SetProperty(ref _selectedFinalReservedTime, value);
    }

    private double _selectedChangeSlideTime = Consts.ChangeSlideTimes[1];
    public double SelectedChangeSlideTime {
      get => _selectedChangeSlideTime;
      set => SetProperty(ref _selectedChangeSlideTime, value);
    }

    private string _wordToPptRules;
    public string WordToPptRules {
      get => _wordToPptRules;
      set => SetProperty(ref _wordToPptRules, value);
    }

    private bool _isAutoLoadAfterBrowse;
    public bool IsAutoLoadAfterBrowse {
      get => _isAutoLoadAfterBrowse;
      set => SetProperty(ref _isAutoLoadAfterBrowse, value);
    }

    private bool _isAutoShowDifferAfterLoad;
    public bool IsAutoShowDifferAfterLoad {
      get => _isAutoShowDifferAfterLoad;
      set => SetProperty(ref _isAutoShowDifferAfterLoad, value);
    }

    private DifferenceType _differenceType = DifferenceType.OnlyText;
    public DifferenceType DifferenceType {
      get => _differenceType;
      set => SetProperty(ref _differenceType, value);
    }

    public DelegateCommand TryParseWordToPptRulesCommand { get; }
    public DelegateCommand RestoreCommand { get; }
    public DelegateCommand<Window> ConfirmCommand { get; }

    public UserSettingsViewModel() {
      TryParseWordToPptRulesCommand = new DelegateCommand(TryParseWordToPptRulesCommand_Execute);
      RestoreCommand = new DelegateCommand(RestoreCommand_Execute);
      ConfirmCommand = new DelegateCommand<Window>(ConfirmCommand_Execute);
      LoadUserSettings();
    }

    private void TryParseWordToPptRulesCommand_Execute() {
      bool flag = WordToPptRulesUtils.TryParseWordToPptRules(WordToPptRules, out List<Dictionary<ProcessType, (string, string)>> allRuleInfos);
      if (flag) {
        ShowMsgBox.Info(allRuleInfos.ToInfoTexts());
      }
    }

    private void RestoreCommand_Execute() {
      Settings.Default.Reset();
      LoadUserSettings();
    }

    private void LoadUserSettings() {
      SelectedUpperLimitTime = Settings.Default.UpperLimitTime;
      SelectedFinalReservedTime = Settings.Default.FinalReservedTime;
      SelectedChangeSlideTime = Settings.Default.ChangeSlideTime;
      IsAutoLoadAfterBrowse = Settings.Default.IsAutoLoadAfterBrowse;
      IsAutoShowDifferAfterLoad = Settings.Default.IsAutoShowDifferAfterLoad;
      DifferenceType = Settings.Default.DifferenceType.ToDifferenceType();
      WordToPptRules = Settings.Default.WordToPptRules;
    }

    private void ConfirmCommand_Execute(Window window) {
      if (!WordToPptRulesUtils.TryParseWordToPptRules(WordToPptRules, out List<Dictionary<ProcessType, (string, string)>> _)) {
        return;
      }

      SaveUserSettings();
      window.Close();
    }

    private void SaveUserSettings() {
      Settings.Default.UpperLimitTime = SelectedUpperLimitTime;
      Settings.Default.FinalReservedTime = SelectedFinalReservedTime;
      Settings.Default.ChangeSlideTime = SelectedChangeSlideTime;
      Settings.Default.IsAutoLoadAfterBrowse = IsAutoLoadAfterBrowse;
      Settings.Default.IsAutoShowDifferAfterLoad = IsAutoShowDifferAfterLoad;
      Settings.Default.DifferenceType = DifferenceType.ToString();
      Settings.Default.WordToPptRules = WordToPptRules;
      Settings.Default.Save();
    }

  }
}
