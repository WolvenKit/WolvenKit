using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace VanWassenhove.Util
{
    public class SortableBindingList<T> : BindingList<T>
    {
        #region Fields

        private bool isSorted;
        private ListSortDirection listSortDirection;
        private PropertyDescriptor propertyDescriptor;

        #endregion Fields

        #region Properties

        protected override bool IsSortedCore => this.isSorted;
        protected override ListSortDirection SortDirectionCore => this.listSortDirection;
        protected override PropertyDescriptor SortPropertyCore => this.propertyDescriptor;
        protected override bool SupportsSortingCore => true;

        #endregion Properties

        #region Methods

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

        #endregion Methods
    }
}
