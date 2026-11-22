using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using WolvenKit.App.Helpers;
using WolvenKit.App.ViewModels.Documents;

namespace WolvenKit.Views.Documents
{
    /// <summary>
    /// The Sector Objects tab of a sector. The rows are grouped by node range and kind here, and filtered with the view
    /// model's <see cref="RDTSectorObjectsViewModel.Matches"/>.
    /// </summary>
    public partial class RDTSectorObjectsView : UserControl
    {
        private RDTSectorObjectsViewModel _viewModel;

        public RDTSectorObjectsView()
        {
            InitializeComponent();
            DataContextChanged += (_, _) => Attach(DataContext as RDTSectorObjectsViewModel);
        }

        private void Attach(RDTSectorObjectsViewModel viewModel)
        {
            if (_viewModel is not null)
            {
                _viewModel.FilterChanged -= OnFilterChanged;
                _viewModel.PropertyChanged -= OnViewModelPropertyChanged;
            }

            _viewModel = viewModel;
            if (_viewModel is not null)
            {
                _viewModel.FilterChanged += OnFilterChanged;
                _viewModel.PropertyChanged += OnViewModelPropertyChanged;
            }

            BuildView();
        }

        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(RDTSectorObjectsViewModel.Objects):
                    BuildView();
                    break;
                // an object picked in the preview: in view once its group has opened
                case nameof(RDTSectorObjectsViewModel.SelectedObject) when _viewModel?.SelectedObject is { } item:
                    Dispatcher.BeginInvoke(new Action(() => ObjectsGrid.ScrollIntoView(item)), System.Windows.Threading.DispatcherPriority.Background);
                    break;
                default:
                    break;
            }
        }

        private void CopyXlRemoval_OnClick(object sender, RoutedEventArgs e) =>
            _viewModel?.CopyXlRemoval(ObjectsGrid.SelectedItems.OfType<SectorObject>());

        private void CopyXlRemovalEntries_OnClick(object sender, RoutedEventArgs e) =>
            _viewModel?.CopyXlRemoval(ObjectsGrid.SelectedItems.OfType<SectorObject>(), entriesOnly: true);

        private void CopyXlMutation_OnClick(object sender, RoutedEventArgs e) =>
            _viewModel?.CopyXlMutation(ObjectsGrid.SelectedItems.OfType<SectorObject>());

        private void CopyXlMutationEntries_OnClick(object sender, RoutedEventArgs e) =>
            _viewModel?.CopyXlMutation(ObjectsGrid.SelectedItems.OfType<SectorObject>(), entriesOnly: true);

        private void BuildView()
        {
            if (_viewModel is null)
            {
                ObjectsGrid.SetCurrentValue(ItemsControl.ItemsSourceProperty, null);
                return;
            }

            var view = new ListCollectionView(_viewModel.Objects.ToList())
            {
                Filter = item => item is SectorObject o && _viewModel.Matches(o),
            };

            using (view.DeferRefresh())
            {
                view.GroupDescriptions.Add(new PropertyGroupDescription(nameof(SectorObject.VariantName)));
                view.GroupDescriptions.Add(new PropertyGroupDescription(nameof(SectorObject.Group)));
                view.SortDescriptions.Add(new SortDescription(nameof(SectorObject.VariantOrder), ListSortDirection.Ascending));
                view.SortDescriptions.Add(new SortDescription(nameof(SectorObject.Group), ListSortDirection.Ascending));
                view.SortDescriptions.Add(new SortDescription(nameof(SectorObject.NodeDataIndex), ListSortDirection.Ascending));
            }

            ObjectsGrid.SetCurrentValue(ItemsControl.ItemsSourceProperty, view);
        }

        private void OnFilterChanged(object sender, EventArgs e)
        {
            if (ObjectsGrid.ItemsSource is ICollectionView view)
            {
                view.Refresh();
            }
        }

        private void ObjectsGrid_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // rows only, not group headers or the column headers
            if (e.OriginalSource is DependencyObject source &&
                ItemsControl.ContainerFromElement(ObjectsGrid, source) is DataGridRow { Item: SectorObject item })
            {
                _viewModel?.OpenInDataCommand.Execute(item);
                e.Handled = true;
            }
        }
    }
}
