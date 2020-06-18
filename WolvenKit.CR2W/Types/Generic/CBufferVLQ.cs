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
    public class CBufferVLQ<T> : CArrayBase<T> where T : CVariable
    {
        public CBufferVLQ(CR2WFile cr2w) : base(cr2w)
        {

        }

        public override void Read(BinaryReader file, uint size)
        {
            elementcount = (int)file.ReadBit6();

            base.Read(file, size);
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

        public override CVariable Create(CR2WFile cr2w) => new CBufferVLQ<T>(cr2w);
    }
}