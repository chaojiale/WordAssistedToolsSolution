using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordAssistedTools.ViewModels {
  public class ParagraphInfoViewModel : BindableBase {
		private int _id;
    public int Id {
			get => _id;
			set {
				_id = value;
				RaisePropertyChanged();
			}
		}

		private string _text;
    public string Text {
			get => _text;
			set {
				_text = value;
				RaisePropertyChanged();
			}
		}

		private bool _isChecked;
    public bool IsChecked {
			get => _isChecked;
			set {
				_isChecked = value;
        UpdateParaInfoEvent?.Invoke(this, EventArgs.Empty);
        RaisePropertyChanged();
			}
		}

		private int _realParaWordCount;
    public int RealParaWordCount {
			get => _realParaWordCount;
			set {
        _realParaWordCount = value;
				RaisePropertyChanged();
			}
		}

		private int _estimateParaWordCount;
    public int EstimateParaWordCount {
			get => _estimateParaWordCount;
			set {
				_estimateParaWordCount = value;
        UpdateParaInfoEvent?.Invoke(this, EventArgs.Empty);
        RaisePropertyChanged();
			}
		}

		private double _oldOnlyParaSeconds;
    public double OldOnlyParaSeconds {
			get => _oldOnlyParaSeconds;
			set {
				_oldOnlyParaSeconds = value;
				RaisePropertyChanged();
			}
		}

		private double _oldStartToParaStartSeconds;
    public double OldStartToParaStartSeconds {
			get => _oldStartToParaStartSeconds;
			set {
				_oldStartToParaStartSeconds = value;
				RaisePropertyChanged();
			}
		}

		private double _oldStartToParaEndSeconds;
    public double OldStartToParaEndSeconds {
			get => _oldStartToParaEndSeconds;
			set {
				_oldStartToParaEndSeconds = value;
				RaisePropertyChanged();
			}
		}

    private double _newOnlyParaSeconds;
    public double NewOnlyParaSeconds {
      get => _newOnlyParaSeconds;
      set {
        _newOnlyParaSeconds = value;
        RaisePropertyChanged();
      }
    }

    private double _newStartToParaStartSeconds;
    public double NewStartToParaStartSeconds {
      get => _newStartToParaStartSeconds;
      set {
        _newStartToParaStartSeconds = value;
        RaisePropertyChanged();
      }
    }

    private double _newStartToParaEndSeconds;
    public double NewStartToParaEndSeconds {
      get => _newStartToParaEndSeconds;
      set {
        _newStartToParaEndSeconds = value;
        RaisePropertyChanged();
      }
    }

		private int _originWordParaId;

		public int OriginWordParaId {
			get => _originWordParaId;
			set {
				_originWordParaId = value;
				RaisePropertyChanged();
			}
		}

		private bool _validState;

		public bool ValidState {
			get => _validState;
			set {
				_validState = value;
				RaisePropertyChanged();
			}
		}

		private bool _isSelected;

		public bool IsSelected {
			get => _isSelected;
			set {
				_isSelected = value;
				RaisePropertyChanged();
			}
		}


		public event EventHandler UpdateParaInfoEvent;

	}
}
