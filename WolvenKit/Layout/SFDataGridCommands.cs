using System.Collections;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;
using DynamicData;
using Syncfusion.UI.Xaml.Grid;
using WolvenKit.Common.Interfaces;

namespace WolvenKit.Layout
{
    public static class SFDataGridCommands
    {
        public static readonly RoutedCommand CheckAndUnCheck = new(nameof(CheckAndUnCheck), typeof(SFDataGridCommands));

        static SFDataGridCommands() => CommandManager.RegisterClassCommandBinding(typeof(CheckBox), new CommandBinding(CheckAndUnCheck, OnCheckUnCheckCommand, OnCanExecuteCheckAndUnCheck));

        private static void OnCanExecuteCheckAndUnCheck(object sender, CanExecuteRoutedEventArgs args) => args.CanExecute = true;

        private static void OnCheckUnCheckCommand(object sender, ExecutedRoutedEventArgs args)
        {
            if (args.Parameter is not SfDataGrid sfdatagrid)
            {
                return;
            }
            if (sender is not CheckBox checkBox)
            {
                return;
            }

            // NOTE: this is needed because sfdatagrid.SelectAll() does not send OnSelectionChanged events
            if (checkBox.IsChecked.Value)
            {
                sfdatagrid.SelectedItems.AddRange(sfdatagrid.ItemsSource as IEnumerable<object>);
            }
            else
            {
                sfdatagrid.SelectedItems.RemoveMany(sfdatagrid.ItemsSource as IEnumerable<object>);
            }
        }
    }
}
