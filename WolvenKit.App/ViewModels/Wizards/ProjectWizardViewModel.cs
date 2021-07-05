using System.Windows.Input;
using System.Windows.Media;
using Catel.MVVM;
using Catel.Services;
using WolvenKit.Functionality.Commands;

namespace WolvenKit.ViewModels.Wizards
{
    public class ProjectWizardViewModel : ViewModelBase
    {
        #region Fields

        private readonly ISelectDirectoryService _selectDirectoryService;

        
        


        #endregion Fields

        #region Constructors

        public ProjectWizardViewModel(
            ISelectDirectoryService selectDirectoryService
            ) : base(null)
        {
            _selectDirectoryService = selectDirectoryService;



            OpenProjectPathCommand = new RelayCommand(ExecuteOpenProjectPath, CanOpenProjectPath);
            FinishCommand = new RelayCommand(ExecuteFinish, CanFinish);
            CancelCommand = new RelayCommand(ExecuteCancel, CanCancel);
        }

        #endregion Constructors

        public ICommand OpenProjectPathCommand { get; private set; }
        public ICommand FinishCommand { get; private set; }
        public ICommand CancelCommand { get; private set; }

        private bool CanCancel() => true;

        private void ExecuteCancel() => this.CancelAndCloseViewModelAsync();


        private bool CanFinish() => AllFieldsValid;

        private void ExecuteFinish() => this.SaveAndCloseViewModelAsync();


        private bool CanOpenProjectPath() => true;

        private async void ExecuteOpenProjectPath()
        {
            var result = await _selectDirectoryService.DetermineDirectoryAsync(
                new DetermineDirectoryContext()
            );
            if (result.Result)
            {
                ProjectPath = result.DirectoryName;
            }
        }

        
        #region Properties

        public string ProjectName { get; set; }
        public string ProjectPath { get; set; }


        /// <summary>
        /// Gets/Sets if all the fields are valid.
        /// </summary>
        public bool AllFieldsValid
        {
            get => _allFieldsValid;
            set
            {
                if (_allFieldsValid != value)
                {
                    var oldValue = _allFieldsValid;
                    _allFieldsValid = value;
                    RaisePropertyChanged(() => AllFieldsValid, oldValue, value);
                }
            }
        }

        private bool _allFieldsValid;

        ///// <summary>
        ///// Gets/Sets the author's profile image brush.
        ///// </summary>
        //public ImageBrush ProfileImageBrush { get; set; }

        ///// <summary>
        ///// Gets/Sets the author's profile image path.
        ///// </summary>
        //public string ProfileImageBrushPath { get; set; }

        #endregion Properties
    }
}
