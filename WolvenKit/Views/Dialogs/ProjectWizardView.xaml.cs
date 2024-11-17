using System.Reactive.Disposables;
using System.Windows.Controls;
using ReactiveUI;
using Splat;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs
{
    public partial class ProjectWizardView : ReactiveUserControl<ProjectWizardViewModel>
    {
        private bool _syncModName = true;
        private bool _autoUpdate = false;

        public ProjectWizardView()
        {
            InitializeComponent();

            this.WhenActivated(disposables =>
            {
                _syncModName = true;
                _autoUpdate = false;

                this.Bind(ViewModel,
                        vm => vm.Author,
                        v => v.AuthorTextBox.Text).DisposeWith(disposables);
                this.Bind(ViewModel,
                        vm => vm.Email,
                        v => v.EmailTextBox.Text).DisposeWith(disposables);
                this.Bind(ViewModel,
                        vm => vm.Version,
                        v => v.VersionTextBox.Text).DisposeWith(disposables);

                this.BindCommand(ViewModel,
                    vm => vm.OpenProjectPathCommand,
                    v => v.ProjectPathButton).DisposeWith(disposables);

                this.BindCommand(ViewModel, 
                        x => x.OkCommand, 
                        x => x.OkButton).DisposeWith(disposables);

                this.BindCommand(ViewModel, 
                        x => x.CancelCommand, 
                        x => x.CancelButton).DisposeWith(disposables);

                ViewModel.ValidateProjectName();
                ViewModel.ValidateProjectPath();
                ViewModel.ValidateModName();

                ReadDefaultValuesFromSettings();
                VersionTextBox.SetCurrentValue(TextBox.TextProperty, "1.0.0");
            });
        }

        private void ReadDefaultValuesFromSettings()
        {
            var settings = Locator.Current.GetService<ISettingsManager>();
            if (settings is null)
            {
                return;
            }

            if (settings.ModderName is not null)
            {
                AuthorTextBox.SetCurrentValue(TextBox.TextProperty, settings.ModderName);
            }

            if (settings.ModderEmail is not null)
            {
                EmailTextBox.SetCurrentValue(TextBox.TextProperty, settings.ModderEmail);
            }
        }

        private void ProjectNameTextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!_syncModName)
            {
                return;
            }

            _autoUpdate = true;
            ModNameTextBox.SetCurrentValue(TextBox.TextProperty, ProjectNameTextBox.Text);
            _autoUpdate = false;
        }

        private void ModNameTextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!_autoUpdate)
            {
                _syncModName = false;
            }
        }
    }
}
