using System;
using System.Reactive.Disposables;
using ReactiveUI;
using Splat;
using WolvenKit.App.ViewModels.Shell;

namespace WolvenKit.Views.Shell
{
    public partial class StatusBarView : ReactiveUserControl<StatusBarViewModel>
    {
        #region Constructors

        public StatusBarView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<StatusBarViewModel>();
            DataContext = ViewModel;

            this.WhenActivated(disposables =>
            {
                this.OneWayBind(ViewModel,
                        x => x.Progress,
                        x => x.StatusBarProgressBar.Progress)
                    .DisposeWith(disposables);
                this.OneWayBind(ViewModel,
                        x => x.IsIndeterminate,
                        x => x.StatusBarProgressBar.IsIndeterminate)
                    .DisposeWith(disposables);
            });

        }

        #endregion Constructors

        private void StatusBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            if (!e.Handled)
            {
                var mainWindow = (MainView)Locator.Current.GetService<IViewFor<AppViewModel>>();
                mainWindow?.DragMove();
            }
        }
    }
}
