using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;
using DynamicData;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.TreeGrid;
using WolvenKit.Common.Interfaces;

namespace WolvenKit.Layout
{
    public static class SFDataGridCommands
    {
        public static readonly RoutedCommand CheckAndUnCheck = new(nameof(CheckAndUnCheck), typeof(SFDataGridCommands));

        static SFDataGridCommands() => CommandManager.RegisterClassCommandBinding(typeof(CheckBox), new CommandBinding(CheckAndUnCheck, OnCheckUnCheckCommand, OnCanExecuteCheckAndUnCheck));

        private static void OnCanExecuteCheckAndUnCheck(object sender, CanExecuteRoutedEventArgs args) => args.CanExecute = true;

        // NOTE: this is needed because sfdatagrid.SelectAll() does not send OnSelectionChanged events
        private static void OnCheckUnCheckCommand(object sender, ExecutedRoutedEventArgs args)
        {
            if (args.Parameter is not SfDataGrid { ItemsSource: IEnumerable<object> source } sfDataGrid ||
                sender is not CheckBox checkBox || checkBox.IsChecked is null)
            {
                return;
            }

            if (checkBox.IsChecked.Value)
            {
                sfDataGrid.SelectedItems.AddRange(source);
            }
            else
            {
                sfDataGrid.SelectedItems.RemoveMany(source);
            }
        }
    }
}
