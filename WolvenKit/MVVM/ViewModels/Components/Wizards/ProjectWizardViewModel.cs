using System.Windows.Media;
using Catel.MVVM;

namespace WolvenKit.MVVM.ViewModels.Components.Wizards
{
    class ProjectWizardViewModel : ViewModelBase
    {
        #region Fields
        private bool _allFieldIsValid = false;
        private ImageBrush _profileImageBrush = default(ImageBrush);
        private string _profileImagePath = "";
        #endregion Fields

        #region Constructors
        public ProjectWizardViewModel() : base(null)
        {
        }
        #endregion Constructors

        #region Properties
        /// <summary>
        /// Gets/Sets if all the fields are valid.
        /// </summary>
        public bool AllFieldIsValid
        {
            get => _allFieldIsValid;
            set
            {
                _allFieldIsValid = value;
                RaisePropertyChanged(nameof(AllFieldIsValid));
            }
        }

        /// <summary>
        /// Gets/Sets the author's profile image brush.
        /// </summary>
        public ImageBrush ProfileImageBrush
        {
            get => _profileImageBrush;
            set
            {
                _profileImageBrush = value;
                RaisePropertyChanged(nameof(ProfileImageBrush));
            }
        }

        /// <summary>
        /// Gets/Sets the author's profile image path.
        /// </summary>
        public string ProfileImageBrushPath
        {
            get => _profileImagePath;
            set
            {
                _profileImagePath = value;
                RaisePropertyChanged(nameof(ProfileImageBrushPath));
            }
        }
        #endregion Properties
    }
}
