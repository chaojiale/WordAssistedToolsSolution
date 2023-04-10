using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace WordAssistedTools.ViewModels {
  public class WordPptCompareViewModel: BindableBase {
		private int _id;
		public int Id {
			get => _id;
			set {
				_id = value;
				RaisePropertyChanged();
			}
		}

		private int _wordId;
		public int WordId {
			get => _wordId;
			set {
				_wordId = value;
				RaisePropertyChanged();
			}
		}


		private bool _isChecked;
    public bool IsChecked {
			get => _isChecked;
			set {
				_isChecked = value;
        UpdateCheckedItemsEvent?.Invoke(this, EventArgs.Empty);
        RaisePropertyChanged();
      }
		}

		private string _wordTime;
		public string WordTime {
			get => _wordTime;
			set {
				_wordTime = value;
				RaisePropertyChanged();
			}
		}

		private string _wordText;
		public string WordText {
			get => _wordText;
			set {
				_wordText = value;
				RaisePropertyChanged();
			}
		}

		private string _pptTime;
		public string PptTime {
			get => _pptTime;
			set {
				_pptTime = value;
        IsSameTime = PptTime == WordTime;
				RaisePropertyChanged();
			}
		}

		private string _pptText;
		public string PptText {
			get => _pptText;
			set {
				_pptText = value;
        IsSameText = PptText.TrimEnd() == WordText.TrimEnd();
				RaisePropertyChanged();
			}
		}

		private bool _isSameTime;
		public bool IsSameTime {
			get => _isSameTime;
			set {
				_isSameTime = value;
				RaisePropertyChanged();
			}
		}

		private bool _isSameText;
		public bool IsSameText {
			get => _isSameText;
			set {
				_isSameText = value;
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

		private bool _isShowDiffer;
		public bool IsShowDiffer {
			get => _isShowDiffer;
			set {
				_isShowDiffer = value;
				RaisePropertyChanged();
			}
		}


		public event EventHandler UpdateCheckedItemsEvent;
	}
}
