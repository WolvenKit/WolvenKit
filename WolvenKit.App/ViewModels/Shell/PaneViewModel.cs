using System.Windows.Media;
using Catel.MVVM;
using WolvenKit.Models.Docking;

namespace WolvenKit.ViewModels.Shell
{
    public class PaneViewModel : ViewModelBase, IDockElement
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
            State = DockState.Dock;
        }

        #endregion constructors

        #region Properties

        public string Header { get; set; }
        public DockState State { get; set; }

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
