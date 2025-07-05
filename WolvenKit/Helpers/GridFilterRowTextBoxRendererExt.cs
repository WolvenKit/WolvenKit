using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.RowFilter;
using System.Windows.Controls;
using Syncfusion.UI.Xaml.Grid.Helpers;

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

        var filterPredicates = GetFilterPredicates(filterValue);
        var filterText = filterValue is string s && s.Contains(' ') ? s : GetFilterText(filterPredicates);

        ApplyFilters(filterPredicates, filterText);
            
        IsValueChanged = false;
    }

    protected new List<FilterPredicate> GetFilterPredicates(object o)
    {
        if (FilterRowCell.DataColumn.GridColumn is null || o is not string filterValue)
        {
            return null;
        }

        var strings = filterValue.Split(' ');

        return strings
            .Select(filterString => new FilterPredicate()
            {
                FilterBehavior = FilterBehavior.StringTyped,
                FilterMode = ColumnFilter.Value,
                FilterType = FilterType.Contains,
                FilterValue = filterString,
                IsCaseSensitive = false,
                PredicateType = strings.Length > 1 ? PredicateType.And : PredicateType.OrElse
            })
            .ToList();
    }

}
    