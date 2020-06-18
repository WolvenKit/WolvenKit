using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using WolvenKit.CR2W.Editors;
using System.Linq;
using WolvenKit.CR2W.Reflection;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace WolvenKit.CR2W.Types
{

    [REDMeta()]
    public abstract class CArrayBase<T> : CVariable, IList<T>, IList where T : CVariable
    {
        
        public List<T> elements { get; set; } = new List<T>();

        [Browsable(false)]
        public int elementcount { get; set; }

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


        [Browsable(false)]
        public List<int> Flags { get; set; }

        [Browsable(false)]
        public T this[int index] { get => ((IList<T>)elements)[index]; set => ((IList<T>)elements)[index] = value; }

        public CArrayBase(CR2WFile cr2w) : base(cr2w)
        {

        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return elements.Cast<IEditableVariable>().ToList();
        }

        public override void Read(BinaryReader file, uint size)
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
                elements.Add(element as T);
            }
        }

        public override void Write(BinaryWriter file)
        {
            CUInt32 count = new CUInt32(cr2w);
            count.val = (uint)elements.Count;
            count.Write(file);

            foreach (var element in elements)
            {
                element.Write(file);
            }
        }

       

        public override bool CanAddVariable(IEditableVariable newvar)
        {
            return newvar == null || newvar is T;
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

        public override bool CanRemoveVariable(IEditableVariable child)
        {
            return true;
        }

        public override void RemoveVariable(IEditableVariable child)
        {
            if (child is T)
            {
                elements.Remove(child as T);
                UpdateNames();
            }
        }

        public override void AddVariable(CVariable variable)
        {
            if (variable is T)
            {
                variable.REDName = elements.Count.ToString();
                elements.Add(variable as T);
            }
        }

        private void UpdateNames()
        {
            for (int i = 0; i < elements.Count; i++)
            {
                elements[i].REDName = i.ToString();
            }
        }

        #region interface implements
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
            ((IList<T>)elements).Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            ((IList<T>)elements).RemoveAt(index);
        }

        public void Add(T item)
        {
            ((IList<T>)elements).Add(item);
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
            return ((IList<T>)elements).Remove(item);
        }

        public int Add(object value)
        {
            return ((IList)elements).Add(value);
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
            ((IList)elements).Insert(index, value);
        }

        public void Remove(object value)
        {
            ((IList)elements).Remove(value);
        }

        public void CopyTo(Array array, int index)
        {
            ((IList)elements).CopyTo(array, index);
        }
        #endregion

    }
}