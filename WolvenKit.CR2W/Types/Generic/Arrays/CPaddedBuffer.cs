using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta()]
    public class CPaddedBuffer<T> : CVariable where T : CVariable
    {
        public List<T> elements = new List<T>();
        public Func<CR2WFile, T> elementFactory;
        public CFloat padding;

        public CPaddedBuffer(CR2WFile cr2w, CVariable parent, string name, Func<CR2WFile, T> elementFactory) : base(cr2w, parent, name)
        {
            this.elementFactory = elementFactory;
            padding = new CFloat(cr2w, this, "padding" );
        }

        public override CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new CPaddedBuffer<T>(cr2w, parent, name, elementFactory);
        }

        public override void Read(BinaryReader file, uint size)
        {
            CDynamicInt count = new CDynamicInt(cr2w, null, "");
            count.Read(file, size);

            for (int i = 0; i < count.val; i++)
            {
                T element = elementFactory.Invoke(cr2w);

                element.Read(file, size);
                elements.Add(element);
            }

            padding.Read(file, 4);
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(elements)
            {
                padding,
            };
        }

        public override void Write(BinaryWriter file)
        {
            CDynamicInt count = new CDynamicInt(cr2w, null, "");
            count.val = elements.Count;
            count.Write(file);

            foreach (var element in elements)
            {
                element.Write(file);
            }

            padding.Write(file);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var copy = base.Copy(context) as CPaddedBuffer<T>;

            foreach (var element in elements)
            {
                copy.elements.Add(element.Copy(context) as T);
            }

            copy.padding = (CFloat)padding.Copy(context);

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

        public override bool RemoveVariable(IEditableVariable child)
        {
            if (child is T)
            {
                elements.Remove(child as T);
                UpdateNames();
                return true;
            }
            return false;
        }

        public override void AddVariable(CVariable variable)
        {
            if (variable is T)
            {
                variable.SetREDName(elements.Count.ToString());
                elements.Add(variable as T);
            }
        }

        private void UpdateNames()
        {
            for (int i = 0; i < elements.Count; i++)
            {
                elements[i].SetREDName(i.ToString());
            }
        }
    }

   
}