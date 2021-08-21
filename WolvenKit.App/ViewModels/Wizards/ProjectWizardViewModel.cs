using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.WindowsAPICodePack.Dialogs;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.ViewModels.Dialogs;
using WolvenKit.Functionality.Commands;

namespace WolvenKit.ViewModels.Wizards
{
    public class ProjectWizardViewModel : DialogViewModel
    {
        #region Fields

        public const string WitcherGameName = "Witcher 3";
        public const string CyberpunkGameName = "Cyberpunk 2077";

        #endregion Fields

        #region Constructors

        public ProjectWizardViewModel()
        {
            Title = "Project Wizard";


            OpenProjectPathCommand = new RelayCommand(ExecuteOpenProjectPath, CanOpenProjectPath);

            CloseCommand = ReactiveCommand.Create(() => { });
            OkCommand = ReactiveCommand.Create(() => { }, CanExecute);
            CancelCommand = ReactiveCommand.Create(() => { });

            ProjectType = new ObservableCollection<string> {"Cyberpunk 2077"};
            //ProjectType.Add("Witcher 3");
        }

        #endregion Constructors

        public sealed override ReactiveCommand<Unit, Unit> CloseCommand { get; set; }
        public sealed override ReactiveCommand<Unit, Unit> CancelCommand { get; set; }
        public sealed override ReactiveCommand<Unit, Unit> OkCommand { get; set; }


        #region Properties

        public sealed override string Title { get; set; }

        [Reactive] public string ProjectName { get; set; }
        [Reactive] public string ProjectPath { get; set; }
        [Reactive] public ObservableCollection<string> ProjectType { get; set; }

        private IObservable<bool> CanExecute =>
            this.WhenAnyValue(
                x => x.AllFieldsValid,
                (b) => b == true
            );

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

        public ICommand OpenProjectPathCommand { get; private set; }



        private bool CanOpenProjectPath() => true;

        private void ExecuteOpenProjectPath()
        {
            var dlg = new CommonOpenFileDialog
            {
                AllowNonFileSystemItems = false,
                Multiselect = false,
                IsFolderPicker = true,
                Title = "Select the WolvenKit project folder"
            };
            //dlg.Filters.Add(new CommonFileDialogFilter("Cyberpunk 2077 Project", "*.cpmodproj"));

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

        

    }
}
