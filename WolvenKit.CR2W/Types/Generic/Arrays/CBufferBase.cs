using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;
using WolvenKit.CR2W.Reflection;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.CodeDom;

namespace WolvenKit.CR2W.Types
{
    [REDMeta()]
    public abstract class CBufferBase<T> : CVariable, IList<T>, IList, IBufferAccessor where T : CVariable
    {
        public CBufferBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        #region Properties
        public List<T> elements { get; set; } = new List<T>();


        [Browsable(false)]
        public List<int> Flags { get; set; }
        #endregion

        public string Elementtype
        {
            get => REDReflection.GetREDTypeString(typeof(T));
            set => throw new NotImplementedException();
        }
        public Type InnerType => this.GetType().GetGenericArguments().Single();

        [Browsable(false)]
        public override string REDType
        {
            get
            {
                return Flags != null
                    ? REDReflection.GetREDTypeString(this.GetType(), Flags.ToArray())
                    : REDReflection.GetREDTypeString(this.GetType());
            }
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return elements.Cast<IEditableVariable>().ToList();
        }


        public override void Read(BinaryReader file, uint size)
        {
            throw new NotImplementedException();
        }

        public void Read(BinaryReader file, uint size, int elementcount)
        {
            string redtype;
            if (Flags == null)
                redtype = REDReflection.GetREDTypeString(typeof(T));
            else
                redtype = REDReflection.GetREDTypeString(typeof(T), Flags.ToArray());

            for (int i = 0; i < elementcount; i++)
            {
                CVariable element = CR2WTypeManager.Create(redtype, i.ToString(), cr2w, this);

                element.Read(file, 0);
                element.IsSerialized = true;
                if (element is T te)
                    elements.Add(te);
            }
        }

        public override void Write(BinaryWriter file)
        {
            foreach (var element in elements)
            {
                element.Write(file);
            }
        }

        public override bool CanAddVariable(IEditableVariable newvar)
        {
            return newvar == null || newvar is T;
        }

        public override void AddVariable(CVariable variable)
        {
            if (variable is T tvar)
            {
                variable.SetREDName(elements.Count.ToString());
                tvar.IsSerialized = true;
                elements.Add(tvar);
            }
        }
        public void AddVariableWithName(CVariable variable)
        {
            if (variable is T tvar)
            {
                tvar.IsSerialized = true;
                elements.Add(tvar);
            }
        }
        public override bool CanRemoveVariable(IEditableVariable child)
        {
            return child is T && elements.Count > 0;
        }

        public override bool RemoveVariable(IEditableVariable child)
        {
            if (child is T tvar)
            {
                elements.Remove(tvar);
                UpdateNames();
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            var builder = new StringBuilder().Append(elements.Count);

            if (elements.Count > 0)
            {
                builder.Append(":");

                foreach (var element in elements)
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

        private void UpdateNames()
        {
            for (int i = 0; i < elements.Count; i++)
            {
                elements[i].SetREDName(i.ToString());
            }
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var copy = base.Copy(context) as CBufferBase<T>;
            context.Parent = copy;

            foreach (var element in elements)
            {
                var ccopy = element.Copy(context);
                if (ccopy is T copye)
                    copy.elements.Add(copye);
            }

            return copy;
        }

        #region interface implements

        [Browsable(false)]
        public T this[int index] { get => ((IList<T>)elements)[index]; set => ((IList<T>)elements)[index] = value; }

        public int Count => ((IList<T>)elements).Count;

        public bool IsReadOnly => ((IList<T>)elements).IsReadOnly;

        public bool IsFixedSize => ((IList)elements).IsFixedSize;

        public object SyncRoot => ((IList)elements).SyncRoot;

        public bool IsSynchronized => ((IList)elements).IsSynchronized;

        object IList.this[int index] { get => ((IList)elements)[index]; set => ((IList)elements)[index] = value; }

        public IEnumerator<T> GetEnumerator()
        {
            return elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return ((IList<T>)elements).IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException(); 
            //((IList<T>)elements).Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
            //((IList<T>)elements).RemoveAt(index);
        }

        public void Add(T item)
        {
            AddVariable(item as CVariable);
        }

        public void Clear()
        {
            ((IList<T>)elements).Clear();
        }

        public bool Contains(T item)
        {
            return ((IList<T>)elements).Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            ((IList<T>)elements).CopyTo(array, arrayIndex);
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
                return elements.Count;
            }
            return -1;
        }

        public bool Contains(object value)
        {
            return ((IList)elements).Contains(value);
        }

        public int IndexOf(object value)
        {
            return ((IList)elements).IndexOf(value);
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
            //((IList)elements).Insert(index, value);
        }

        public void Remove(object value)
        {
            if (value is T cvar)
                RemoveVariable(cvar);
        }

        public void CopyTo(Array array, int index)
        {
            ((IList)elements).CopyTo(array, index);
        }
        #endregion

    }
}