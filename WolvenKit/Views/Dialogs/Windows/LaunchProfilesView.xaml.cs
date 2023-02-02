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

                //Observable
                //    .FromEventPattern(WizardControl, nameof(Syncfusion.Windows.Tools.Controls.WizardControl.Finish))
                //    .Subscribe(_ => ViewModel.OkCommand.Execute().Subscribe())
                //    .DisposeWith(disposables);

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
            if (e.DropPosition != DropPosition.None)
            {
                // Get Dragging records
                var draggingRecords = e.Data.GetData("Records") as ObservableCollection<object>;

                // Gets the TargetRecord from the underlying collection using record index of the TargetRecord (e.TargetRecord)
                var model = ProfilesListView.DataContext as LaunchProfilesViewModel;
                var targetRecord = model.LaunchProfiles[(int)e.TargetRecord];

                // Use Batch update to avoid data operatons in SfDataGrid during records removing and inserting
                ProfilesListView.BeginInit();

                // Removes the dragging records from the underlying collection
                foreach (var item in draggingRecords.Cast<LaunchProfileViewModel>())
                {
                    model.LaunchProfiles.Remove(item);
                }

                // Find the target record index after removing the records
                var targetIndex = model.LaunchProfiles.IndexOf(targetRecord);
                var insertionIndex = e.DropPosition == DropPosition.DropAbove ? targetIndex : targetIndex + 1;
                insertionIndex = insertionIndex < 0 ? 0 : insertionIndex;

                // Insert dragging records to the target position
                for (var i = draggingRecords.Count - 1; i >= 0; i--)
                {
                    model.LaunchProfiles.Insert(insertionIndex, draggingRecords[i] as LaunchProfileViewModel);
                }
                ProfilesListView.EndInit();
            }
        }
    }
}
