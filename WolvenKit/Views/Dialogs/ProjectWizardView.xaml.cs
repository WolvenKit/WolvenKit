using System;
using System.Reactive.Disposables;
using System.Windows.Controls;
using System.Windows.Input;
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

            //this.WhenAnyValue(x => x.ViewModel)
            //    .BindTo(this, x => x.DataContext);


            this.WhenActivated(disposables =>
            {
                _syncModName = true;
                _autoUpdate = false;
                
                //this.Bind(ViewModel,
                //    vm => vm,
                //    v => v.DataContext).DisposeWith(disposables);

                //Observable
                //    .FromEventPattern(wizardControl, nameof(WizardControl.Finish))
                //    .Subscribe(_ => ViewModel.OkCommand.Execute().Subscribe())
                //    .DisposeWith(disposables);

                //Observable
                //    .FromEventPattern(wizardControl, nameof(WizardControl.Cancel))
                //    .Subscribe(_ => ViewModel.CancelCommand.Execute().Subscribe())
                //    .DisposeWith(disposables);

                this.Bind(ViewModel,
                        vm => vm.ProjectName,
                        v => v.ProjectNameTextBox.Text).DisposeWith(disposables);
                this.Bind(ViewModel,
                        vm => vm.ProjectPath,
                        v => v.ProjectPathTextBox.Text).DisposeWith(disposables);
                this.Bind(ViewModel,
                    vm => vm.ModName,
                    v => v.ModNameTextBox.Text).DisposeWith(disposables);
                this.Bind(ViewModel,
                        vm => vm.Author,
                        v => v.AuthorTextBox.Text).DisposeWith(disposables);
                this.Bind(ViewModel,
                        vm => vm.Email,
                        v => v.EmailTextBox.Text).DisposeWith(disposables);
                this.Bind(ViewModel,
                        vm => vm.Version,
                        v => v.VersionTextBox.Text).DisposeWith(disposables);
                //this.OneWayBind(ViewModel,
                //        vm => vm.ProjectType,
                //        v => v.ProjectypeTextBox.ItemsSource)
                //    .DisposeWith(disposables);
                //this.Bind(ViewModel,
                //        vm => vm.AllFieldsValid,
                //        v => v.wizardControl.FinishEnabled)
                //    .DisposeWith(disposables);


                this.BindCommand(ViewModel,
                    vm => vm.OpenProjectPathCommand,
                    v => v.ProjectPathButton).DisposeWith(disposables);

                this.BindCommand(ViewModel, x => x.OkCommand, x => x.OkButton)
               .DisposeWith(disposables);

                this.BindCommand(ViewModel, x => x.CancelCommand, x => x.CancelButton)
                    .DisposeWith(disposables);


                ProjectNameTextBox.VerifyData();
                ModNameTextBox.VerifyData();

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

        private HandyControl.Data.OperationResult<bool> VerifyProjectName(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return HandyControl.Data.OperationResult.Failed("Please enter a Project name!");
            }

            if (System.IO.Directory.Exists(System.IO.Path.Combine(ProjectPathTextBox.Text, ProjectNameTextBox.Text)))
            {
                return HandyControl.Data.OperationResult.Failed("A project with this name already exists!");
            }
            
            return HandyControl.Data.OperationResult.Success();
        }

        private HandyControl.Data.OperationResult<bool> VerifyModName(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return HandyControl.Data.OperationResult.Failed("Please enter a mod name!");
            }

            return HandyControl.Data.OperationResult.Success();
        }

        private HandyControl.Data.OperationResult<bool> VerifyFolder(string str)
        {
            if (!System.IO.Directory.Exists(str))
            {
                return HandyControl.Data.OperationResult.Failed("Selected path does not exist");
            }

            ProjectNameTextBox.VerifyData();

            return HandyControl.Data.OperationResult.Success();
        }
            

        //private void ButtonClose(object sender, RoutedEventArgs e) => throw new NotImplementedException();

        //private void ButtonMinimize(object sender, RoutedEventArgs e) => throw new NotImplementedException();

        //private void DraggableTitleBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => throw new NotImplementedException();

        private void ProjectNameTextBox_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (ProjectNameTextBox.Text != ModNameTextBox.Text)
            {
                return;
            }

            ModNameTextBox.SetCurrentValue(TextBox.TextProperty, ProjectNameTextBox.Text);
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
