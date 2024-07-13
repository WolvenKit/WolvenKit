using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using HandyControl.Controls;
using ReactiveUI;
using Splat;
using Syncfusion.UI.Xaml.Grid;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Core;
using Window = System.Windows.Window;

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

                if (ViewModel is not null)
                {
                    ViewModel.IsUpdating += OnInternalUpdate;
                }


                ProfilesListView.RowDragDropController.Dropped += OnRowDropped;
            });

        }

        private void OnInternalUpdate(object sender, bool isUpdating)
        {
            if (isUpdating)
            {
                // Use Batch update to avoid data operations in SfDataGrid during records removing and inserting
                ProfilesListView.BeginInit();
            }
            else
            {
                ProfilesListView.EndInit();
            }
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

            var offset = 1;

            // Handle offset from drop position
            if (e.DropPosition == DropPosition.DropBelow)
            {
                offset = 1;
            }
            else if (e.DropPosition == DropPosition.DropAbove)
            {
                offset = -1;
            }

            // Handle out-of-bounds
            if (offset == 1 && targetPos >= (ViewModel?.LaunchProfiles.Count ?? 99))
            {
                offset = -1;
            }

            if (offset == -1 && targetPos == 0)
            {
                offset = 1;
            }

            OnInternalUpdate(null, true);

            foreach (var draggingRecord in draggingRecords)
            {
                if (draggingRecord is not LaunchProfile profile)
                {
                    continue;
                }

                model.UpdateLaunchProfileIndex(profile, targetPos, offset);
            }


            OnInternalUpdate(null, false);
        }

        private string _savegameDisplayName;

        private string GetSavegameNameProperty()
        {
            if (_savegameDisplayName is not null)
            {
                return _savegameDisplayName;
            }

            var propertyInfo = typeof(LaunchProfile).GetProperty("LoadSaveName");
            var displayAttribute = propertyInfo?.GetCustomAttributes(typeof(DisplayAttribute), false).FirstOrDefault() as DisplayAttribute;
            if (displayAttribute != null)
            {
                _savegameDisplayName = displayAttribute.Name;
            }

            _savegameDisplayName ??= "Load specific savegame";
            return _savegameDisplayName;
        }

        /// <summary>
        /// Opens save game dialogue when user clicks on the field
        /// </summary>
        private void PropertyGrid_SelectedPropertyItemChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var savegameNameProperty = GetSavegameNameProperty();
            // Check if a property was selected
            if (e.NewValue is not Syncfusion.Windows.PropertyGrid.PropertyItem propertyItem
                || ViewModel?.SelectedLaunchProfile?.Profile is not LaunchProfile lp
                || propertyItem.DisplayName != savegameNameProperty
               )
            {
                return;
            }

            ViewModel.SetLaunchProfileSaveName(Interactions.ShowSelectSaveView(lp.LoadSaveName));
            ProfilePropertyGrid.RefreshPropertygrid();
        }
    }
}
