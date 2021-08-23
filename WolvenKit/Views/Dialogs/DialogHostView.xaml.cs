using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ReactiveUI;
using Splat;
using WolvenKit.ViewModels.Dialogs;

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

            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                    vm => vm.HostedViewModel,
                    view => view.ViewModelViewHost.ViewModel)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        vm => vm.HostedViewModel.Title,
                        view => view.Title)
                    .DisposeWith(disposables);

            });

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
