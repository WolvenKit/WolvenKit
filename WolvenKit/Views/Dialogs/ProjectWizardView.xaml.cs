using System;
using System.Reactive.Disposables;
using System.Windows.Controls;
using ReactiveUI;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs
{
    public partial class ProjectWizardView : ReactiveUserControl<ProjectWizardViewModel>
    {
        public ProjectWizardView()
        {
            InitializeComponent();

            //this.WhenAnyValue(x => x.ViewModel)
            //    .BindTo(this, x => x.DataContext);


            this.WhenActivated(disposables =>
            {
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
                        v => v.xprojectNameTxtbx.Text).DisposeWith(disposables);
                this.Bind(ViewModel,
                        vm => vm.ProjectPath,
                        v => v.projectPathTxtbx.Text).DisposeWith(disposables);
                this.Bind(ViewModel,
                        vm => vm.Author,
                        v => v.projectAuthorTxtbx.Text).DisposeWith(disposables);
                this.Bind(ViewModel,
                        vm => vm.Email,
                        v => v.projectEmailTxtbx.Text).DisposeWith(disposables);
                this.Bind(ViewModel,
                        vm => vm.Version,
                        v => v.projectVersionTxtbx.Text).DisposeWith(disposables);
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


                xprojectNameTxtbx.VerifyData();
            });
        }

        private HandyControl.Data.OperationResult<bool> VerifyModName(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return HandyControl.Data.OperationResult.Failed("Please enter a Project name!");
            }

            if (System.IO.Directory.Exists(System.IO.Path.Combine(projectPathTxtbx.Text, xprojectNameTxtbx.Text)))
            {
                return HandyControl.Data.OperationResult.Failed("A project with this name already exists!");
            }
            
            return HandyControl.Data.OperationResult.Success();
        }

        private HandyControl.Data.OperationResult<bool> VerifyFolder(string str)
        {
            if (!System.IO.Directory.Exists(str))
            {
                return HandyControl.Data.OperationResult.Failed("Selected path does not exist");
            }

            xprojectNameTxtbx.VerifyData();

            return HandyControl.Data.OperationResult.Success();
        }
            

        //private void ButtonClose(object sender, RoutedEventArgs e) => throw new NotImplementedException();

        //private void ButtonMinimize(object sender, RoutedEventArgs e) => throw new NotImplementedException();

        //private void DraggableTitleBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => throw new NotImplementedException();


    }
}
