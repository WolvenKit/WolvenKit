using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using Splat;
using Syncfusion.UI.Xaml.Grid;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Core;

namespace WolvenKit.Views.Dialogs.Windows
{
    public partial class LaunchProfilesView : IViewFor<LaunchProfilesViewModel>
    {
        public LaunchProfilesView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<LaunchProfilesViewModel>();
            DataContext = ViewModel;

            this.WhenActivated(disposables =>
            {
                this.BindCommand(ViewModel, x => x.NewItemCommand, x => x.ToolbarNewItem)
                   .DisposeWith(disposables);
                this.BindCommand(ViewModel, x => x.DuplicateItemCommand, x => x.ToolbarDuplicateItem)
                   .DisposeWith(disposables);
                this.BindCommand(ViewModel, x => x.DeleteItemCommand, x => x.ToolbarDeleteItem)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel, x => x.PositionDownCommand, x => x.ToolbarDownItem)
                   .DisposeWith(disposables);
                this.BindCommand(ViewModel, x => x.PositionUpCommand, x => x.ToolbarUpItem)
                    .DisposeWith(disposables);

                ProfilesListView.RowDragDropController.Dropped += OnRowDropped;
            });

        }

        public LaunchProfilesViewModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (LaunchProfilesViewModel)value; }

        public bool? ShowDialog(Window owner)
        {
            Owner = owner;
            return ShowDialog();
        }

        private void ProfilePropertyGrid_AutoGeneratingPropertyGridItem(object sender, Syncfusion.Windows.PropertyGrid.AutoGeneratingPropertyGridItemEventArgs e)
        {
            switch (e.DisplayName)
            {
                case nameof(ReactiveObject.Changed):
                case nameof(ReactiveObject.Changing):
                case nameof(ReactiveObject.ThrownExceptions):
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }

        //https://help.syncfusion.com/wpf/datagrid/drag-and-drop#reorder-the-source-collection-while-drag-and-drop-the-rows
        private void OnRowDropped(object sender, GridRowDroppedEventArgs e)
        {
            if (e.DropPosition == DropPosition.None
                || ProfilesListView.DataContext is not LaunchProfilesViewModel model
                || e.TargetRecord is not int targetPos)
            {
                return;
            }

            // Get Dragging records
            var draggingRecords = e.Data.GetData("Records") as ObservableCollection<object>;

            // Use Batch update to avoid data operations in SfDataGrid during records removing and inserting
            ProfilesListView.BeginInit();

            model.UpdateLaunchProfileIndex(targetPos, draggingRecords?.Count ?? 0);

            ProfilesListView.EndInit();
        }
    }
}
