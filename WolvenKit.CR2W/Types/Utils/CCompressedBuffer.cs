using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CCompressedBuffer<T> : CVariable, IList<T> where T : CVariable
    {
        public List<T> elements = new List<T>();
        public Func<CR2WFile, T> elementFactory;

        private int m_count = -1;
        public new string Type { get => $"CCompressedBuffer<{typeof(T)}>"; }

        public int Count => ((ICollection<T>)elements).Count;

        public bool IsReadOnly => ((ICollection<T>)elements).IsReadOnly;

        public T this[int index] { get => ((IList<T>)elements)[index]; set => ((IList<T>)elements)[index] = value; }

        public CCompressedBuffer(CR2WFile cr2w, Func<CR2WFile, T> elementFactory) : base(cr2w)
        {
            this.elementFactory = elementFactory;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CCompressedBuffer<T>(cr2w, elementFactory);
        }

        public void Read(BinaryReader file, uint size, int count)
        {
            m_count = count;
            Read(file, size);
        }

        public override void Read(BinaryReader file, uint size)
        {
            if (m_count == -1)
                throw new Exception("Count not set for Compressed Buffer.");

            for (int i = 0; i < m_count; i++)
            {
                T element = elementFactory.Invoke(cr2w);
                element.Name = i.ToString();
                element.Read(file, size);
                elements.Add(element);
            }
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(elements);
        }

        public override void Write(BinaryWriter file)
        {
            foreach (var element in elements)
            {
                element.Write(file);
            }
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var copy = base.Copy(context) as CCompressedBuffer<T>;

            foreach (var element in elements)
            {
                copy.elements.Add(element.Copy(context) as T);
            }

            return copy;
        }

        public override CVariable CreateDefaultVariable()
        {
            return elementFactory.Invoke(cr2w);
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
                variable.Name = elements.Count.ToString();
                elements.Add(variable as T);
            }
        }

        private void UpdateNames()
        {
            for (int i = 0; i < elements.Count; i++)
            {
                elements[i].Name = i.ToString();
            }
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
            ((ICollection<T>)elements).Add(item);
        }

        public void Clear()
        {
            ((ICollection<T>)elements).Clear();
        }

        public bool Contains(T item)
        {
            return ((ICollection<T>)elements).Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            ((ICollection<T>)elements).CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            return ((ICollection<T>)elements).Remove(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)elements).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)elements).GetEnumerator();
        }
    }
}