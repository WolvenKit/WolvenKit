using System;

namespace WolvenKit.RED4.Types
{
    public delegate void ObjectChangedEventHandler(object sender, ObjectChangedEventArgs e);

    public class ObjectChangedEventArgs : EventArgs
    {
        public ObjectChangedType ChangeType { get; set; }

        public string RedPath { get; internal set; }
        public string RedName { get; internal set; }

        public object OldValue { get; }
        public object NewValue { get; }

        public ObjectChangedEventArgs(ObjectChangedType changeType, string redPath, string redName, object oldValue, object newValue)
        {
            ChangeType = changeType;
            RedPath = redPath;
            RedName = redName;
            OldValue = oldValue;
            NewValue = newValue;
        }
    }

    public enum ObjectChangedType
    {
        None,
        Added,
        Modified,
        Deleted
    }
}
