using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ReactiveUI;

namespace WolvenKit.Converters;

public class CollectionToCollectionTypeConverter : IBindingTypeConverter
{
    public int GetAffinityForObjects(Type fromType, Type toType)
    {
        if ((fromType == typeof(List<object>) && toType == typeof(ObservableCollection<object>)) ||
            (fromType == typeof(ObservableCollection<object>) && toType == typeof(List<object>)))
        {
            return 10;
        }

        return 0;
    }

    public bool TryConvert(object from, Type toType, object conversionHint, out object result)
    {
        if (from == null)
        {
            result = null;
            return true;
        }

        if (toType == typeof(ObservableCollection<object>) && from is IEnumerable<object> enumerable)
        {
            result = new ObservableCollection<object>(enumerable);
            return true;
        }

        if (toType == typeof(List<object>) && from is IEnumerable<object> enumerableList)
        {
            result = enumerableList.ToList();
            return true;
        }

        result = from;
        return false;
    }
}