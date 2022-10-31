using System.Reactive.Disposables;
using ReactiveUI;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs
{
    public partial class ProjectWizardView : ReactiveUserControl<ProjectWizardViewModel>
    {
        private System.Windows.Threading.DispatcherTimer timer;

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


                Disposable.Create(() => StopTimer()).DisposeWith(disposables);

            });
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (timer == null)
            {
                StartTimer();
            }
            ValidateAllFields();
        }

        private void StartTimer()
        {
            if (timer == null)
            {
                timer = new System.Windows.Threading.DispatcherTimer();
                timer.Tick += new System.EventHandler(OnTimer);
                timer.Interval = new System.TimeSpan(0, 0, 1);
                timer.Start();
            }
        }

        private void StopTimer()
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Tick -= new System.EventHandler(OnTimer);
                timer = null;
            }
        }


        private void OnTimer(object sender, System.EventArgs e)
            => ValidateAllFields();

        private void ValidateAllFields()
        {
            if (ViewModel is { } vm)
            {
                vm.AllFieldsValid = /*projectNameTxtbx.VerifyData() &&*/ projectPathTxtbx.VerifyData();
            }
        }

        private HandyControl.Data.OperationResult<bool> VerifyFolder(string str)
            => System.IO.Directory.Exists(str)
                ? HandyControl.Data.OperationResult.Success()
                : HandyControl.Data.OperationResult.Failed("Selected path does not exist");

        private HandyControl.Data.OperationResult<bool> VerifyIfProjectExists(string str)
            => string.IsNullOrEmpty(str) || System.IO.Directory.Exists(System.IO.Path.Combine(projectPathTxtbx.Text, xprojectNameTxtbx.Text))
                ? HandyControl.Data.OperationResult.Failed("WolvenKit project exists")
                : HandyControl.Data.OperationResult.Success();

        //private void ButtonClose(object sender, RoutedEventArgs e) => throw new NotImplementedException();

        //private void ButtonMinimize(object sender, RoutedEventArgs e) => throw new NotImplementedException();

        //private void DraggableTitleBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => throw new NotImplementedException();


    }
}
