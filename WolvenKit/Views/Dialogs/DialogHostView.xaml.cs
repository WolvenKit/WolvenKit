using System;
using System.Reactive.Disposables;
using ReactiveUI;
using Splat;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs
{
    /// <summary>
    /// Interaction logic for DialogHostWindow.xaml
    /// </summary>
    public partial class DialogHostView : IViewFor<DialogHostViewModel>
    {
        public DialogHostViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (DialogHostViewModel)value;
        }

        public DialogHostView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<DialogHostViewModel>();

            this.WhenActivated(disposables => this.Bind(ViewModel,
                    vm => vm.HostedViewModel,
                    view => view.ViewModelViewHost.ViewModel)
                    .DisposeWith(disposables));

        }


        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{
        //    var mainWindow = Application.Current.MainWindow;

        //    var l = mainWindow.Left + ((mainWindow.Width ) / 2) - (this.ActualWidth / 2);
        //    var t = mainWindow.Top + ((mainWindow.Height ) / 2) - (this.ActualHeight / 2);

        //    this.SetCurrentValue(LeftProperty, l);
        //    this.SetCurrentValue(TopProperty, t);

        //}
    }
}
