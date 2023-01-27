using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Reactive;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.WindowsAPICodePack.Dialogs;
using ReactiveUI;
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.App.ViewModels.Dialogs
{
    public partial class ProjectWizardViewModel : DialogViewModel
    {
        #region Fields

        public delegate Task ReturnHandler(ProjectWizardViewModel? project);
        public ReturnHandler? FileHandler;

        public const string WitcherGameName = "Witcher 3";
        public const string CyberpunkGameName = "Cyberpunk 2077";

        #endregion Fields

        #region Constructors

        public ProjectWizardViewModel()
        {
            Title = "Project Wizard";


            OpenProjectPathCommand = ReactiveCommand.Create(ExecuteOpenProjectPath);

            CloseCommand = ReactiveCommand.Create(() => { });
#pragma warning disable IDE0053 // Use expression body for lambda expressions
            OkCommand = ReactiveCommand.Create(() => { FileHandler?.Invoke(this); }, CanExecute);
            CancelCommand = ReactiveCommand.Create(() => { FileHandler?.Invoke(null); });
#pragma warning restore IDE0053 // Use expression body for lambda expressions

            _projectType = new ObservableCollection<string> { "Cyberpunk 2077" };
        }

        #endregion Constructors

        #region Properties

        public string Title { get; set; }

        [NotNull]
        [ObservableProperty] private string? _projectName = null!;
        [NotNull]
        [ObservableProperty] private string? _projectPath = null!;
        [ObservableProperty] private string? _author;
        [ObservableProperty] private string? _email;
        [ObservableProperty] private string? _version;
        [ObservableProperty] private ObservableCollection<string> _projectType = new();

        private IObservable<bool> CanExecute =>
            this.WhenAnyValue(
                x => x.AllFieldsValid,
                (b) => b == true
            );

        /// <summary>
        /// Gets/Sets if all the fields are valid.
        /// </summary>
        [ObservableProperty] private bool _allFieldsValid;

        ///// <summary>
        ///// Gets/Sets the author's profile image brush.
        ///// </summary>
        //public ImageBrush ProfileImageBrush { get; set; }

        ///// <summary>
        ///// Gets/Sets the author's profile image path.
        ///// </summary>
        //public string ProfileImageBrushPath { get; set; }

        #endregion Properties

        public ReactiveCommand<Unit, Unit> CloseCommand { get; set; }

        public override ReactiveCommand<Unit, Unit> CancelCommand { get; }

        public override ReactiveCommand<Unit, Unit> OkCommand { get; }

        [ObservableProperty] private string? _whyNotCreate;

        public ReactiveCommand<Unit, Unit> OpenProjectPathCommand { get; private set; }

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
