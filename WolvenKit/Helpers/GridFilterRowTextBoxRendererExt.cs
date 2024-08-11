using System.Windows;
using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.RowFilter;
using System.Windows.Controls;

namespace WolvenKit.Helpers;

public class GridFilterRowTextBoxRendererExt : GridFilterRowTextBoxRenderer
{
    protected override void OnEditElementLostFocus(object sender, RoutedEventArgs e)
    {
        base.OnEditElementLostFocus(sender, e);

        ProcessSingleFilter(GetControlValue());
    }
    public override void ProcessSingleFilter(object filterValue)
    {
        if (FilterRowCell.DataColumn.GridColumn == null)
        {
            return;
        }

        var filterPredicates = this.GetFilterPredicates(GetControlValue());
        foreach (var filterPredicate in filterPredicates)
        {
            filterPredicate.FilterBehavior = FilterBehavior.StringTyped;
        }

        var filterText = this.GetFilterText(filterPredicates);
        ApplyFilters(filterPredicates, filterText);
        IsValueChanged = false;
    }
}