using System;
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
    public class CBufferVLQ<T> : CVariable where T : CVariable
    {
        public List<T> elements = new List<T>();
        public Func<CR2WFile, T> elementFactory;

        public CBufferVLQ(CR2WFile cr2w, Func<CR2WFile, T> elementFactory) : base(cr2w)
        {
            this.elementFactory = elementFactory;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CBufferVLQ<T>(cr2w, elementFactory);
        }

        public override void Read(BinaryReader file, uint size)
        {
            CDynamicInt count = new CDynamicInt(cr2w);
            count.Read(file, size);

            for (int i = 0; i < count.val; i++)
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
            CDynamicInt count = new CDynamicInt(cr2w);
            count.val = elements.Count;
            count.Write(file);

            foreach (var element in elements)
            {
                element.Write(file);
            }
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var copy = base.Copy(context) as CBufferVLQ<T>;

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
    }

    class CBuffers
    {
        public static CBufferVLQ<CName> CreateCNameBuffer(CR2WFile cr2w, string name)
        {
            return new CBufferVLQ<CName>(cr2w, file => new CName(file) { Type = "CName" }) { Name = name, Type = "CBuffer<CName>" };
        }
        public static CBufferVLQ<CFloat> CreateFloatBuffer(CR2WFile cr2w, string name)
        {
            return new CBufferVLQ<CFloat>(cr2w, file => new CFloat(file) { Type = "CFloat" }) { Name = name, Type = "CBuffer<CFloat>" };
        }
        public static CBufferVLQ<CUInt16> CreateUInt16Buffer(CR2WFile cr2w, string name)
        {
            return new CBufferVLQ<CUInt16>(cr2w, file => new CUInt16(file) { Type = "CUInt16" }) { Name = name, Type = "CBuffer<CUInt16>" };
        }
        public static CBufferVLQ<CUInt32> CreateUInt32Buffer(CR2WFile cr2w, string name)
        {
            return new CBufferVLQ<CUInt32>(cr2w, file => new CUInt32(file) { Type = "CUInt32" }) { Name = name, Type = "CBuffer<CUInt32>" };
        }
        public static CBufferVLQ<CVector2D> CreateVector2DBuffer(CR2WFile cr2w, string name)
        {
            return new CBufferVLQ<CVector2D>(cr2w, file => new CVector2D(file) { Type = "CVector2D" }) { Name = name, Type = "CBuffer<CVector2D>" };
        }
        public static CBufferVLQ<CVector3D> CreateVector3DBuffer(CR2WFile cr2w, string name)
        {
            return new CBufferVLQ<CVector3D>(cr2w, file => new CVector3D(file) { Type = "CVector3D" }) { Name = name, Type = "CBuffer<CVector3D>" };
        }
    }
}