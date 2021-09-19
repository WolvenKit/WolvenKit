using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WolvenKit.Common.Model.Cr2w;
using System.Linq;
using WolvenKit.RED4.CR2W.Reflection;
using System.ComponentModel;
using WolvenKit.Core.Exceptions;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta()]
    public abstract class CArrayBase<T> : CVariable, IREDArray<T>, IList<T> where T : IEditableVariable
    {
        public CArrayBase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        #region Properties

        private byte[] _buffer;
        public List<T> Elements { get; set; } = new();

        public List<int> Flags { get; set; }

        public string Elementtype
        {
            get => REDReflection.GetREDTypeString(typeof(T));
            set => throw new NotSupportedException();
        }
        public Type InnerType => this.GetType().GetGenericArguments().Single();

        #endregion

        #region methods

        private bool IsByteArray() => typeof(T) == typeof(CUInt8);

        [Browsable(false)]
        public override string REDType => REDReflection.GetREDTypeString(GetType());

        public override List<IEditableVariable> GetEditableVariables() => Elements.Cast<IEditableVariable>().ToList();

        public override void Read(BinaryReader file, uint size) => throw new NotImplementedException("CArrayBase.Read");

        public IEditableVariable GetElementInstance(string varName)
        {
            if (IsByteArray())
            {
                throw new NotImplementedException();
            }

            var element = Create<T>(varName, Array.Empty<int>());
            if (element is not IEditableVariable evar)
            {
                throw new MissingRTTIException(varName, Elementtype, this.REDType);
            }

            evar.IsSerialized = true;
            return evar;
        }

        protected void Read(BinaryReader file, uint size, int elementcount)
        {
            // read as byte array for perfomance
            if (IsByteArray())
            {
                _buffer = file.ReadBytes(elementcount);
                return;
            }

            for (var i = 0; i < elementcount; i++)
            {
                var element = Create<T>(i.ToString(), new int[0]);

                // no actual way to find out the elementsize of an array element
                // because cdpr serialized classes have no fixed size
                // solution? not sure: pass 0 and disable checks?

                var elementsize = 0;
                if (element is IDataBufferAccessor)
                {
                    elementsize = (int) ((size - 4) / elementcount);
                }

                element.Read(file, (uint)elementsize);
                if (element is { } te)
                {
                    te.IsSerialized = true;
                    Elements.Add(te);
                }
            }
        }

        protected void ReadWithoutMeta(BinaryReader file, uint size, int elementcount)
        {
            // read as byte array for perfomance
            if (IsByteArray())
            {
                _buffer = file.ReadBytes(elementcount);
                return;
            }

            for (var i = 0; i < elementcount; i++)
            {
                var element = CR2WTypeManager.Create(Elementtype, i.ToString(), cr2w, this);

                // no actual way to find out the elementsize of an array element
                // bacause cdpr serialized classes have no fixed size
                // solution? not sure: pass 0 and disable checks?

                var elementsize = 0;
                if (element is IDataBufferAccessor)
                    elementsize = (int)((size - 4) / elementcount);

                element.ReadWithoutMeta(file, (uint)elementsize);

                if (element is T te)
                {
                    te.IsSerialized = true;
                    Elements.Add(te);
                }
            }
        }

        public override void Write(BinaryWriter file)
        {
            // write as byte array for perfomance
            if (IsByteArray() && _buffer != null)
            {
                file.Write(_buffer);
                return;
            }

            foreach (var element in Elements)
            {
                element.Write(file);
            }
        }

        public override void WriteWithoutMeta(BinaryWriter file)
        {
            // write as byte array for perfomance
            if (IsByteArray() && _buffer != null)
            {
                file.Write(_buffer);
                return;
            }

            foreach (var element in Elements)
            {
                if (!(element is CVariable elem))
                {
                    throw new NotSupportedException();
                }

                elem.WriteWithoutMeta(file);
            }
        }

        public override CVariable SetValue(object val)
        {
            this.IsSerialized = true;
            if (val is CArrayBase<T> cvar)
            {
                this.Elements = cvar.Elements;
            }

            return this;
        }

        public override bool CanAddVariable(IEditableVariable newvar) => newvar is null or T;

        public override void AddVariable(IEditableVariable variable)
        {
            if (IsByteArray())
            {
                throw new NotImplementedException();
            }

            if (variable is T tvar)
            {
                variable.SetREDName(Elements.Count.ToString());
                tvar.IsSerialized = true;
                Elements.Add(tvar);
            }
        }

        public override bool CanRemoveVariable(IEditableVariable child)
        {
            if (IsByteArray())
            {
                throw new NotImplementedException();
            }

            return child is T && Elements.Count > 0;
        }

        public override bool RemoveVariable(IEditableVariable child)
        {
            if (IsByteArray())
            {
                throw new NotImplementedException();
            }

            if (child is T tvar)
            {
                Elements.Remove(tvar);
                UpdateNames();
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            var builder = new StringBuilder().Append(Elements.Count);

            if (Elements.Count > 0)
            {
                builder.Append(":");

                foreach (var element in Elements)
                {
                    builder.Append(" <").Append(element).Append(">");

                    if (builder.Length > 100)
                    {
                        builder.Remove(100, builder.Length - 100);
                        break;
                    }
                }
            }

            if (IsByteArray())
            {
                builder.Append(_buffer.Length).Append(" bytes");
            }

            return builder.ToString();
        }

        public override string REDLeanValue() => "";

        /// <summary>
        /// Usually CArrayBase elements's names are indices, so reindexes
        /// </summary>
        private void UpdateNames()
        {
            for (int i = 0; i < Elements.Count; i++)
            {
                Elements[i].SetREDName(i.ToString());
            }
        }

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var copy = base.Copy(context) as CArrayBase<T>;
            context.Parent = copy;

            foreach (var element in Elements)
            {
                var ccopy = element.Copy(context);
                if (ccopy is T copye)
                {
                    copy.Elements.Add(copye);
                }
            }

            copy._buffer = this._buffer;

            return copy;
        }

        #endregion

        #region interface implements

        [Browsable(false)]
        public T this[int index]
        {
            get
            {
                if (IsByteArray() && _buffer is { Length: > 0 })
                {
                    // super dumb but without refactoring most of the code this is it
                    var element = Create<T>(index.ToString(), new int[0]);
                    element.SetValue(_buffer[index]);
                    return element;
                }
                return ((IList<T>)Elements)[index];
            }
            set
            {
                if (IsByteArray())
                {
                    throw new NotImplementedException();
                }

                ((IList<T>)Elements)[index] = value;
            }
        }

        public int Count => IsByteArray() ? _buffer.Length : Elements.Count;

        public bool IsReadOnly => ((IList<T>)Elements).IsReadOnly;

        public bool IsFixedSize => ((IList)Elements).IsFixedSize;

        public object SyncRoot => ((IList)Elements).SyncRoot;

        public bool IsSynchronized => ((IList)Elements).IsSynchronized;

        object IList.this[int index]
        {
            get
            {
                if (IsByteArray() && _buffer is { Length: > 0 })
                {
                    //return _buffer[index];
                    // super dumb but without refactoring most of the code this is it
                    var element = Create<T>(index.ToString(), new int[0]);
                    element.SetValue(_buffer[index]);
                    return element;
                }
                return ((IList)Elements)[index];
            }
            set
            {
                if (IsByteArray())
                {
                    throw new NotImplementedException();
                }
                ((IList)Elements)[index] = value;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (IsByteArray())
            {
                throw new NotImplementedException();
            }
            return Elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            if (IsByteArray())
            {
                throw new NotImplementedException();
            }
            return GetEnumerator();
        }

        public int IndexOf(T item)
        {
            if (IsByteArray())
            {
                throw new NotImplementedException();
            }
            return ((IList<T>)Elements).IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException("CarrayBase.Insert");
            //((IList<T>)elements).Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException("CarrayBase.RemoveAt");
            //((IList<T>)elements).RemoveAt(index);
        }

        public void Add(T item) => AddVariable(item as CVariable);

        public void Clear()
        {
            if (IsByteArray())
            {
                _buffer = Array.Empty<byte>();
            }
            ((IList<T>)Elements).Clear();
        }

        public bool Contains(T item)
        {
            if (IsByteArray())
            {
                throw new NotImplementedException();
            }
            return ((IList<T>)Elements).Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (IsByteArray())
            {
                throw new NotImplementedException();
            }
            ((IList<T>)Elements).CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            if (IsByteArray())
            {
                throw new NotImplementedException();
            }
            return RemoveVariable(item);
        }














        public int Add(object value)
        {
            if (IsByteArray())
            {
                throw new NotImplementedException();
            }
            if (value is T tvar)
            {
                AddVariable(tvar as CVariable);
                return Elements.Count;
            }
            return -1;
        }

        public bool Contains(object value)
        {
            if (IsByteArray())
            {
                throw new NotImplementedException();
            }
            return ((IList)Elements).Contains(value);
        }

        public int IndexOf(object value)
        {
            if (IsByteArray())
            {
                throw new NotImplementedException();
            }
            return ((IList)Elements).IndexOf(value);
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException("CarrayBase.Insert");
            //((IList)elements).Insert(index, value);
        }

        public void Remove(object value)
        {
            if (IsByteArray())
            {
                throw new NotImplementedException();
            }
            if (value is T cvar)
                RemoveVariable(cvar);
        }

        public void CopyTo(Array array, int index)
        {
            if (IsByteArray())
            {
                throw new NotImplementedException();
            }
            ((IList)Elements).CopyTo(array, index);
        }
        #endregion

    }
}
