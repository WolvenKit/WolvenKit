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
    /// Interaction logic for NewFileView.xaml
    /// </summary>
    public partial class NewFileView : ReactiveUserControl<NewFileViewModel>
    {
        public NewFileView()
        {
            InitializeComponent();


            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                    vm => vm.Categories,
                    v => v.Categories.ItemsSource)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                    vm => vm.SelectedCategory,
                    v => v.Categories.SelectedItem)
                    .DisposeWith(disposables);

                this.OneWayBind(ViewModel,
                    vm => vm.SelectedCategory.Files,
                    v => v.DataGrid.ItemsSource)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                    vm => vm.SelectedFile,
                    v => v.DataGrid.SelectedItem)
                    .DisposeWith(disposables);

                this.Bind(ViewModel,
                    vm => vm.SelectedFile.Description,
                    v => v.Properties.Text)
                    .DisposeWith(disposables);

                this.Bind(ViewModel,
                    vm => vm.FileName,
                    v => v.FileName.Text)
                    .DisposeWith(disposables);
            });

        }
    }
}
