using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.WindowsAPICodePack.Dialogs;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Functionality.Commands;

namespace WolvenKit.ViewModels.Wizards
{
    public class ProjectWizardViewModel : ReactiveObject
    {
        #region Fields

        public const string WitcherGameName = "Witcher 3";
        public const string CyberpunkGameName = "Cyberpunk 2077";



        #endregion Fields

        #region Constructors

        public ProjectWizardViewModel()
        {



            OpenProjectPathCommand = new RelayCommand(ExecuteOpenProjectPath, CanOpenProjectPath);
            FinishCommand = new RelayCommand(ExecuteFinish, CanFinish);
            CancelCommand = new RelayCommand(ExecuteCancel);

            ProjectType = new ObservableCollection<string> {"Cyberpunk 2077"};
            //ProjectType.Add("Witcher 3");
        }

        #endregion Constructors

        public ICommand OpenProjectPathCommand { get; private set; }
        public ICommand FinishCommand { get; private set; }
        public ICommand CancelCommand { get; private set; }

        private void ExecuteCancel() => throw new NotImplementedException();


        private bool CanFinish() => AllFieldsValid;

        private void ExecuteFinish() => throw new NotImplementedException();


        private bool CanOpenProjectPath() => true;

        private void ExecuteOpenProjectPath()
        {
            var dlg = new CommonOpenFileDialog
            {
                AllowNonFileSystemItems = false,
                Multiselect = false,
                IsFolderPicker = false,
                Title = "Locate the WolvenKit project"
            };
            dlg.Filters.Add(new CommonFileDialogFilter("Cyberpunk 2077 Project", "*.cpmodproj"));

            if (dlg.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }

            var result = dlg.FileName;
            if (string.IsNullOrEmpty(result))
            {
                return;
            }

            ProjectPath = result;
        }

        
        #region Properties

        public string ProjectName { get; set; }
        public string ProjectPath { get; set; }
        public ObservableCollection<string> ProjectType { get; set; }


        /// <summary>
        /// Gets/Sets if all the fields are valid.
        /// </summary>
        [Reactive] public bool AllFieldsValid { get; set; }

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
