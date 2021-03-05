using System;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Variables
{
    public class VariableArrayValue<T> : VariableValue<T[]>
    {
        #region Methods

        public new static VariableArrayValue<T> Create(T[] value)
        {
            return new VariableArrayValue<T>
            {
                Value = value
            };
        }

        #endregion Methods
    }

    public class VariableArrayValue : VariableValue
    {
        #region Properties

        public int Length
        {
            get { return Value.Length; }
        }

        public override object Object
        {
            get { return Value; }
        }

        public Array Value { get; private set; }

        #endregion Properties

        #region Indexers

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

        #endregion Indexers

        #region Methods

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

        #endregion Methods
    }

    public class VariableHandleValue<T> : VariableValue<T>
    {
        #region Methods

        public new static VariableHandleValue<T> Create(T value)
        {
            return new VariableHandleValue<T>
            {
                Value = value
            };
        }

        #endregion Methods
    }

    public class VariableSoftValue<T> : VariableValue<T>
    {
        #region Methods

        public new static VariableSoftValue<T> Create(T value)
        {
            return new VariableSoftValue<T>
            {
                Value = value
            };
        }

        #endregion Methods
    }

    public abstract class VariableValue
    {
        #region Properties

        public abstract object Object { get; }

        #endregion Properties
    }

    public class VariableValue<T> : VariableValue
    {
        #region Properties

        public override object Object
        {
            get { return Value; }
        }

        public T Value { get; set; }

        #endregion Properties

        #region Methods

        public static VariableValue<T> Create(T value)
        {
            return new VariableValue<T>
            {
                Value = value
            };
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        #endregion Methods
    }
}
