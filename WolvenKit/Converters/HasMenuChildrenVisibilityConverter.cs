using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WolvenKit.Converters
{
    public class HasMenuChildrenVisibilityConverter : IValueConverter
    {
        private List<string> subscribedChildNames = new();
        //private bool isSubscribed;
        
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not MenuItem parentMenuItem)
            {
                return Visibility.Collapsed;
            }

            //if (!isSubscribed && parentMenuItem.Items is INotifyCollectionChanged collection)
            //{
            //    collection.CollectionChanged += (sender, args) => SubscribeToChildren(parentMenuItem, true);
            //    isSubscribed = true;
            //}

            SubscribeToChildren(parentMenuItem);
            return GetVisibility(parentMenuItem);

        }

        private void SubscribeToChildren(MenuItem parentMenuItem, bool calledFromEvent = false)
        {
            //foreach (var child in parentMenuItem.Items.OfType<MenuItem>().Where(c => !subscribedChildNames.Contains(c.Name)))
            //{
            //    child.IsVisibleChanged += (_, _) =>
            //        parentMenuItem.SetCurrentValue(UIElement.VisibilityProperty, GetVisibility(parentMenuItem, true));
            //    child.IsEnabledChanged += (_, _) =>
            //        parentMenuItem.SetCurrentValue(UIElement.VisibilityProperty, GetVisibility(parentMenuItem, true));
            //    subscribedChildNames.Add(child.Name);
            //}
        }

        private Visibility GetVisibility(MenuItem parentMenuItem, bool calledFromEvent = false) =>
            parentMenuItem.Items.OfType<MenuItem>().Any(child => child.Visibility == Visibility.Visible && child.IsEnabled)
                ? Visibility.Visible
                : Visibility.Collapsed;

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}