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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ReactiveUI;
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs
{
    /// <summary>
    /// Interaktionslogik für SelectRedTypeDialog.xaml
    /// </summary>
    public partial class SelectRedTypeDialog : ReactiveUserControl<SelectRedTypeDialogViewModel>
    {

        public SelectRedTypeDialog()
        {
            InitializeComponent();

            this.WhenActivated(disposables =>
            {


                this.BindCommand(ViewModel, x => x.OkCommand, x => x.OkButton)
                    .DisposeWith(disposables);

                this.BindCommand(ViewModel, x => x.CancelCommand, x => x.CancelButton)
                    .DisposeWith(disposables);

            });
        }


        private void SetSelectedType(object sender, System.Windows.RoutedEventArgs e) => ViewModel.SelectedTypeString = (sender as Button).Content.ToString();
    }
}
