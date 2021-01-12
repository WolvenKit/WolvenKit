using System.ComponentModel;
using System.Collections.Generic;
using System.Reflection;
using System;

namespace VanWassenhove.Util
{
    public class SortableBindingList<T> : BindingList<T>
    {
        private PropertyDescriptor propertyDescriptor;
        private ListSortDirection listSortDirection;
        private bool isSorted;

        protected override bool SupportsSortingCore => true;

        protected override bool IsSortedCore => this.isSorted;

        protected override PropertyDescriptor SortPropertyCore => this.propertyDescriptor;

        protected override ListSortDirection SortDirectionCore => this.listSortDirection;

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            List<T> itemsList = this.Items as List<T>;
            itemsList.Sort(delegate (T t1, T t2)
            {
                this.propertyDescriptor = prop;
                this.listSortDirection = direction;
                this.isSorted = true;

                int reverse = direction == ListSortDirection.Ascending ? 1 : -1;

                PropertyInfo propertyInfo = typeof(T).GetProperty(prop.Name);
                object value1 = propertyInfo.GetValue(t1, null);
                object value2 = propertyInfo.GetValue(t2, null);

                IComparable comparable = value1 as IComparable;
                if (comparable != null)
                {
                    return reverse * comparable.CompareTo(value2);
                }
                else
                {
                    comparable = value2 as IComparable;
                    if (comparable != null)
                    {
                        return -1 * reverse * comparable.CompareTo(value1);
                    }
                    else
                    {
                        return 0;
                    }
                }
            });

            this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        protected override void RemoveSortCore()
        {
            this.isSorted = false;
            this.propertyDescriptor = base.SortPropertyCore;
            this.listSortDirection = base.SortDirectionCore;
        }
    }
}
