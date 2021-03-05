using System.Windows.Media;
using Catel.MVVM;

namespace WolvenKit.MVVM.ViewModels.Shell.Editor
{
    public class PaneViewModel : ViewModelBase
    {
        #region fields

        private string _contentId = null;
        private bool _isActive = false;
        private bool _isSelected = false;
        private string _title = null;

        #endregion fields

        #region constructors

        public PaneViewModel()
        {
        }

        #endregion constructors

        #region Properties

        public string ContentId
        {
            get => _contentId;
            protected set
            {
                if (_contentId != value)
                {
                    _contentId = value;
                    RaisePropertyChanged(nameof(ContentId));
                }
            }
        }

        public ImageSource IconSource
        {
            get;
            protected set;
        }

        public bool IsActive
        {
            get => _isActive;
            set
            {
                if (_isActive != value)
                {
                    _isActive = value;
                    RaisePropertyChanged(nameof(IsActive));
                }
            }
        }

        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                if (_isSelected != value)
                {
                    _isSelected = value;
                    RaisePropertyChanged(nameof(IsSelected));
                }
            }
        }

        public new string Title
        {
            get => _title;
            set
            {
                if (_title != value)
                {
                    _title = value;
                    RaisePropertyChanged(nameof(Title));
                }
            }
        }

        #endregion Properties
    }
}
