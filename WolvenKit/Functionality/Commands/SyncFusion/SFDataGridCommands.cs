using Catel.IoC;
using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using WolvenKit.ViewModels.Editor;

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
            var sfdatagrid = (args.Parameter as SfDataGrid);
            var viewmodel = ServiceLocator.Default.ResolveType<ImportExportViewModel>();
            var checkbox = (sender as CheckBox).IsChecked;
            if (viewmodel != null)
            {
                if (checkbox == true)
                {
                    sfdatagrid.SelectAll();
                    foreach (var collection in viewmodel.ExportableItems)
                    {
                        if (collection.IsChecked == false)
                            collection.IsChecked = true;
                    }
                }
                else if (checkbox == false)
                {
                    sfdatagrid.ClearSelections(false);
                    foreach (var collection in viewmodel.ExportableItems)
                    {
                        if (collection.IsChecked == true)
                            collection.IsChecked = false;
                    }
                }
            }
        }
    }
}
