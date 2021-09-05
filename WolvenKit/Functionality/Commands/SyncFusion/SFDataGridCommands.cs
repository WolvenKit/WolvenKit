using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Splat;
using WolvenKit.Common.Interfaces;

namespace WolvenKit
{
    public static class SFDataGridCommands
    {
        public static readonly RoutedCommand CheckAndUnCheck = new RoutedCommand(nameof(CheckAndUnCheck), typeof(SFDataGridCommands));

        static SFDataGridCommands()
        {
            CommandManager.RegisterClassCommandBinding(typeof(CheckBox), new CommandBinding(CheckAndUnCheck, OnCheckUnCheckCommand, OnCanExecuteCheckAndUnCheck));
        }

        private static void OnCanExecuteCheckAndUnCheck(object sender, CanExecuteRoutedEventArgs args)
        {
            args.CanExecute = true;
        }

        private static void OnCheckUnCheckCommand(object sender, ExecutedRoutedEventArgs args)
        {
            if (args.Parameter is not SfDataGrid sfdatagrid)
            {
                return;
            }
            var checkbox = (sender as CheckBox).IsChecked;

            if (checkbox == true)
            {
                sfdatagrid.SelectAll();
                foreach (var item in sfdatagrid.SelectedItems)
                {
                    var selectablevm = (ISelectableViewModel)item;
                    if (selectablevm.IsChecked == false)
                        selectablevm.IsChecked = true;
                }
            }
            else if (checkbox == false)
            {
                foreach (var item in sfdatagrid.SelectedItems)
                {
                    var selectablevm = (ISelectableViewModel)item;
                    if (selectablevm.IsChecked == true)
                        selectablevm.IsChecked = false;
                }
                sfdatagrid.ClearSelections(false);
            }
        }
    }
}
