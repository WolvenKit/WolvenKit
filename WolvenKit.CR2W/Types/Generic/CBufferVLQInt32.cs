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
    public class CBufferVLQInt32<T> : CArrayBase<T> where T : CVariable
    {
        public CBufferVLQInt32(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        public override void Read(BinaryReader file, uint size)
        {
            elementcount = (int)file.ReadVLQInt32();

            base.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            CVLQInt32 count = new CVLQInt32(cr2w, null, "");
            count.val = elements.Count;
            count.Write(file);

            foreach (var element in elements)
            {
                element.Write(file);
            }
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var copy = base.Copy(context) as CBufferVLQInt32<T>;

            foreach (var element in elements)
            {
                copy.elements.Add(element.Copy(context) as T);
            }

            return copy;
        }

        public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBufferVLQInt32<T>(cr2w, parent, name);
    }

    
}