using System;

namespace WolvenKit.RED4.Types
{
    public delegate void ObjectChangedEventHandler(object sender, ObjectChangedEventArgs e);

    public class ObjectChangedEventArgs : EventArgs
    {
        public string RedPath { get; internal set; }
        public string RedName { get; internal set; }

        public object OldValue { get; }
        public object NewValue { get; }

        public ObjectChangedEventArgs(string redPath, string redName, object oldValue, object newValue)
        {
            RedPath = redPath;
            RedName = redName;
            OldValue = oldValue;
            NewValue = newValue;
        }
    }
}
