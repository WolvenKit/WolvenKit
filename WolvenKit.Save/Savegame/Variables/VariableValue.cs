using System;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Variables
{
    public abstract class VariableValue
    {
        public abstract object Object { get; }
    }

    public class VariableValue<T> : VariableValue
    {
        public T Value { get; set; }
        public static VariableValue<T> Create(T value)
        {
            return new VariableValue<T>
            {
                Value = value
            };
        }

        public override object Object
        {
            get { return Value; }
        }


        public override string ToString()
        {
            return Value.ToString();
        }
    }

    public class VariableArrayValue<T> : VariableValue<T[]>
    {
        public new static VariableArrayValue<T> Create(T[] value)
        {
            return new VariableArrayValue<T>
            {
                Value = value
            };
        }
    }

    public class VariableArrayValue : VariableValue
    {
        public Array Value { get; private set; }

        public object this[int i]
        {
            get
            {
                return Value.GetValue(i);
            }
            set
            {
                Value.SetValue(value, i);
            }
        }

        public int Length
        {
            get { return Value.Length; }
        }

        public override object Object
        {
            get { return Value; }
        }

        public static VariableArrayValue Create(Type type, int length)
        {
            return new VariableArrayValue
            {
                Value = Array.CreateInstance(type, length)
            };
        }

        public override string ToString()
        {
            return "VariableArrayValue[" + Length + "]";
        }
    }

    public class VariableHandleValue<T> : VariableValue<T>
    {
        public new static VariableHandleValue<T> Create(T value)
        {
            return new VariableHandleValue<T>
            {
                Value = value
            };
        }
    }

    public class VariableSoftValue<T> : VariableValue<T>
    {
        public new static VariableSoftValue<T> Create(T value)
        {
            return new VariableSoftValue<T>
            {
                Value = value
            };
        }
    }
}
