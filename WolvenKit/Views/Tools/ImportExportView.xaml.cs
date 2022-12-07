using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Threading;
using ReactiveUI;
using Splat;
using Syncfusion.UI.Xaml.Grid.Helpers;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.Common;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Services;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Tools;

namespace WolvenKit.Views.Tools
{
    public partial class ImportExportView : ReactiveUserControl<ImportExportViewModel>
    {
        private readonly Dispatcher _dispatcher = Dispatcher.CurrentDispatcher;

        //private PropertyItem _propertyItem;
        private readonly IProjectManager projectManager;
        private readonly Red4ParserService parser;
        private readonly ISettingsManager _settingsManager;

        /// <summary>
        /// Constructor I/E Tool.
        /// </summary>
        public ImportExportView()
        {
            InitializeComponent();

            _settingsManager = Locator.Current.GetService<ISettingsManager>();

            ViewModel = Locator.Current.GetService<ImportExportViewModel>();
            DataContext = ViewModel;

            projectManager = Locator.Current.GetService<IProjectManager>();
            parser = Locator.Current.GetService<Red4ParserService>();


        }

        //private void OnPropertyValueChanged(object sender, PropertyChangedEventArgs e) => _dispatcher.Invoke(() => OverlayPropertyGrid.RefreshPropertygrid());

        /// <summary>
        /// Confirm Button (Advanced Options)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        //{
        //    if (ViewModel != null)
        //    {
        //        if (ApplyToAllCheckbox.IsChecked != null && ApplyToAllCheckbox.IsChecked.Value)
        //        {
        //            ViewModel.CopyArgumentsTemplateToCommand.SafeExecute("All in Grid");
        //            ApplyToAllCheckbox.SetCurrentValue(System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty, false);
        //        }

        //        ViewModel.SaveSettings();



        //        if (ViewModel.IsExportsSelected)
        //        {
        //            ExportGrid.RefreshColumns();
        //        }
        //    }
        //    XAML_AdvancedOptionsOverlay.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
        //}

        /// <summary>
        /// Cancel Button (Select additional files)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelSelectingClick(object sender, RoutedEventArgs e) => XAML_FileSelectingOverlay.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);





        private void Button_Click(object sender, RoutedEventArgs e) => HelpOverlay.SetCurrentValue(VisibilityProperty, Visibility.Visible);

        private void Button_Click_1(object sender, RoutedEventArgs e) => HelpOverlay.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);

        //private void ConfirmCollectionEditorSelection_OnClick(object sender, RoutedEventArgs e)
        //{
        //    XAML_FileSelectingOverlay.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
        //    if (ViewModel is ImportExportViewModel vm)
        //    {
        //        vm.ConfirmCollectionCommand.SafeExecute(_propertyItem.Name);
        //    }
        //}

        private void AddItemsButtonClick(object sender, RoutedEventArgs e)
        {
            if (ViewModel is ImportExportViewModel vm)
            {
                vm.AddItemsCommand.SafeExecute(FileSelectionDataGrid.SelectedItems);
            }
        }

        private void RemoveItemsButtonClick(object sender, RoutedEventArgs e)
        {
            if (ViewModel is ImportExportViewModel vm)
            {
                vm.RemoveItemsCommand.SafeExecute(SelectedFilesGrid.SelectedItems);
            }
        }




    }
}
