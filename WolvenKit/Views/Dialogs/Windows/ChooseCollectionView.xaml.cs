using System.Reactive.Disposables;
using System.Windows;
using ReactiveUI;
using Splat;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs.Windows
{
    /// <summary>
    /// Interaction logic for ChooseCollectionView.xaml
    /// </summary>
    public partial class ChooseCollectionView : IViewFor<ChooseCollectionViewModel>
    {
        public ChooseCollectionView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<ChooseCollectionViewModel>();
            DataContext = ViewModel;


            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                    vm => vm.AvailableItems,
                    v => v.AvailableDataGrid.ItemsSource)
                .DisposeWith(disposables);
                this.Bind(ViewModel,
                    vm => vm.SelectedAvailableItem,
                    v => v.AvailableDataGrid.SelectedItem)
                .DisposeWith(disposables);
                this.Bind(ViewModel,
                    vm => vm.SelectedAvailableItems,
                    v => v.AvailableDataGrid.SelectedItems)
                .DisposeWith(disposables);

                this.Bind(ViewModel,
                    vm => vm.SelectedItems,
                    v => v.SelectedDataGrid.ItemsSource)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                    vm => vm.SelectedSelectedItem,
                    v => v.SelectedDataGrid.SelectedItem)
                .DisposeWith(disposables);
                this.Bind(ViewModel,
                    vm => vm.SelectedSelectedItems,
                    v => v.SelectedDataGrid.SelectedItems)
                .DisposeWith(disposables);

                this.BindCommand(ViewModel,
                    vm => vm.AddItemCommand,
                    v => v.AddButton)
                .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                    vm => vm.RemoveItemCommand,
                    v => v.RemoveButton)
                .DisposeWith(disposables);

            });

        }

        public ChooseCollectionViewModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (ChooseCollectionViewModel)value; }

        public bool? ShowDialog(Window owner)
        {
            Owner = owner;
            return ShowDialog();
        }
    }
}
