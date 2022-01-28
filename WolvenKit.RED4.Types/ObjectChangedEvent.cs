using System;
using System.Collections.Generic;

namespace WolvenKit.RED4.Types
{
    public delegate void ObjectChangedEventHandler(object sender, ObjectChangedEventArgs e);

    public class ObjectChangedEventArgs : EventArgs
    {
        internal CallStack _callStack = new();

        public ObjectChangedType ChangeType { get; set; }

        public string RedPath { get; internal set; }
        public string RedName { get; internal set; }

        public object OldValue { get; }
        public object NewValue { get; }

        public ObjectChangedEventArgs(ObjectChangedType changeType, string redName, object oldValue, object newValue)
        {
            ChangeType = changeType;
            RedName = redName;
            OldValue = oldValue;
            NewValue = newValue;
        }
    }

    public class CallStack : List<IRedType>
    {
        public new bool Contains(IRedType value)
        {
            var comparer = ReferenceEqualityComparer.Instance;

            for (int i = 0; i < Count; i++)
            {
                if (comparer.Equals(this[i], value))
                {
                    return true;
                }
            }

            return false;
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
