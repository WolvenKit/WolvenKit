using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using WolvenKit.Common.Model.Cr2w;
using System.Linq;
using WolvenKit.RED4.CR2W.Reflection;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.CodeDom;
using WolvenKit.Common.Services;
using WolvenKit.Core.Exceptions;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta()]
    public abstract class CArrayBase<T> : CVariable, IREDArray<T>, IList<T> where T : IEditableVariable
    {
        public CArrayBase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        #region Properties

        public List<T> Elements { get; set; } = new List<T>();

        public List<int> Flags { get; set; }

        public string Elementtype
        {
            get => REDReflection.GetREDTypeString(typeof(T));
            set => throw new NotSupportedException();
        }
        public Type InnerType => this.GetType().GetGenericArguments().Single();

        private byte[] _buffer;

        #endregion

        #region methods

        [Browsable(false)]
        public override string REDType => REDReflection.GetREDTypeString(GetType());

        public override List<IEditableVariable> GetEditableVariables() => Elements.Cast<IEditableVariable>().ToList();

        public override void Read(BinaryReader file, uint size)
        {
            throw new NotImplementedException("CArrayBase.Read");
        }

        public IEditableVariable GetElementInstance(string varName)
        {
            var element = Create<T>(varName, Array.Empty<int>());
            if (element is IEditableVariable evar)
            {
                evar.IsSerialized = true;
                return evar;
            }

            throw new MissingRTTIException(varName, Elementtype, this.REDType);
        }



        protected void Read(BinaryReader file, uint size, int elementcount)
        {
            // read as byte array for perfomance
            if (typeof(T) == typeof(CUInt8))
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
            if (typeof(T) == typeof(CUInt8))
            {
                _buffer = file.ReadBytes(elementcount);
                return;
            }

            for (int i = 0; i < elementcount; i++)
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
            if (typeof(T) == typeof(CUInt8) && _buffer != null)
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
            if (typeof(T) == typeof(CUInt8) && _buffer != null)
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

        public override bool CanAddVariable(IEditableVariable newvar)
        {
            return newvar == null || newvar is T;
        }

        public override void AddVariable(IEditableVariable variable)
        {
            if (variable is T tvar)
            {
                variable.SetREDName(Elements.Count.ToString());
                tvar.IsSerialized = true;
                Elements.Add(tvar);
            }
        }

        public override bool CanRemoveVariable(IEditableVariable child)
        {
            return child is T && Elements.Count > 0;
        }

        public override bool RemoveVariable(IEditableVariable child)
        {
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
                    builder.Append(" <").Append(element.ToString()).Append(">");

                    if (builder.Length > 100)
                    {
                        builder.Remove(100, builder.Length - 100);
                        break;
                    }
                }
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

            return copy;
        }

        #endregion

        #region interface implements

        [Browsable(false)]
        public T this[int index]
        {
            get
            {
                if (_buffer is { Length: > 0 })
                {
                    // super dumb but without refactoring most of the code this is it
                    var element = Create<T>(index.ToString(), new int[0]);
                    element.SetValue(_buffer[index]);
                    return element;
                }
                return ((IList<T>)Elements)[index];
            }
            set => ((IList<T>)Elements)[index] = value;
        }

        public int Count => ((IList<T>)Elements).Count;

        public bool IsReadOnly => ((IList<T>)Elements).IsReadOnly;

        public bool IsFixedSize => ((IList)Elements).IsFixedSize;

        public object SyncRoot => ((IList)Elements).SyncRoot;

        public bool IsSynchronized => ((IList)Elements).IsSynchronized;

        object IList.this[int index] { get => ((IList)Elements)[index]; set => ((IList)Elements)[index] = value; }

        public IEnumerator<T> GetEnumerator()
        {
            return Elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int IndexOf(T item)
        {
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

        public void Add(T item)
        {
            AddVariable(item as CVariable);
        }

        public void Clear()
        {
            ((IList<T>)Elements).Clear();
        }

        public bool Contains(T item)
        {
            return ((IList<T>)Elements).Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            ((IList<T>)Elements).CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            return RemoveVariable(item);
        }

        public int Add(object value)
        {
            if (value is T tvar)
            {
                AddVariable(tvar as CVariable);
                return Elements.Count;
            }
            return -1;
        }

        public bool Contains(object value)
        {
            return ((IList)Elements).Contains(value);
        }

        public int IndexOf(object value)
        {
            return ((IList)Elements).IndexOf(value);
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException("CarrayBase.Insert");
            //((IList)elements).Insert(index, value);
        }

        public void Remove(object value)
        {
            if (value is T cvar)
                RemoveVariable(cvar);
        }

        public void CopyTo(Array array, int index)
        {
            ((IList)Elements).CopyTo(array, index);
        }
        #endregion

    }
}
