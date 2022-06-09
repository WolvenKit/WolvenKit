using System;
using System.Collections.ObjectModel;
using System.Reactive;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.WindowsAPICodePack.Dialogs;
using Prism.Commands;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.ViewModels.Wizards
{
    public class ProjectWizardViewModel : DialogViewModel
    {
        #region Fields

        public delegate Task ReturnHandler(ProjectWizardViewModel project);
        public ReturnHandler FileHandler;

        public const string WitcherGameName = "Witcher 3";
        public const string CyberpunkGameName = "Cyberpunk 2077";

        #endregion Fields

        #region Constructors

        public ProjectWizardViewModel()
        {
            Title = "Project Wizard";


            OpenProjectPathCommand = new DelegateCommand(ExecuteOpenProjectPath, CanOpenProjectPath);

            CloseCommand = ReactiveCommand.Create(() => { });
            CreateCommand = ReactiveCommand.Create(() => FileHandler(this), CanExecute);
            Cancel2Command = ReactiveCommand.Create(() => FileHandler(null));

            ProjectType = new ObservableCollection<string> { "Cyberpunk 2077" };
            //ProjectType.Add("Witcher 3");
        }

        #endregion Constructors

        public ReactiveCommand<Unit, Unit> CloseCommand { get; set; }
        public ReactiveCommand<Unit, Unit> CancelCommand { get; set; }
        public ReactiveCommand<Unit, Unit> OkCommand { get; set; }

        public ICommand CreateCommand { get; set; }
        public ICommand Cancel2Command { get; set; }
        [Reactive] public string WhyNotCreate { get; set; }

        #region Properties

        public string Title { get; set; }

        [Reactive] public string ProjectName { get; set; }
        [Reactive] public string ProjectPath { get; set; }
        [Reactive] public string Author { get; set; }
        [Reactive] public string Email { get; set; }
        [Reactive] public string Version { get; set; }
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
                Title = "Select the folder to create the project in"
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
