using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Nodify;

namespace WolvenKit.Views.Editors
{
    public class AutomaticNodifyEditor : NodifyEditor
    {
        public AutomaticNodifyEditor() : base()
        {

        }

        public static readonly RoutedEvent ItemsUpdatedEvent = EventManager.RegisterRoutedEvent(nameof(ItemsUpdated), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(AutomaticNodifyEditor));

        /// <summary>
        /// Occurs whenever the <see cref="Items"/> change.
        /// </summary>
        public event RoutedEventHandler ItemsUpdated
        {
            add => AddHandler(ItemsUpdatedEvent, value);
            remove => RemoveHandler(ItemsUpdatedEvent, value);
        }

        /// <summary>
        /// Raises the <see cref="ItemsUpdatedEvent"/>.
        /// </summary>
        protected void OnItemsUpdated()
            => RaiseEvent(new RoutedEventArgs(ItemsUpdatedEvent, this));

        //public override void OnApplyTemplate()
        //{
        //    base.OnApplyTemplate();
        //    OnItemsUpdated();
        //}

        public Panel GetItemHost()
        {
            return ItemsHost;
        }
    }
}
