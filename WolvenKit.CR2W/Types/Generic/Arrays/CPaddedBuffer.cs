using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta()]
    public class CPaddedBuffer<T> : CBufferBase<T> where T : CVariable
    {
        public CFloat padding;

        public CPaddedBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            padding = new CFloat(cr2w, this, "padding" );
        }

        public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPaddedBuffer<T>(cr2w, parent, name);

        public override void Read(BinaryReader file, uint size)
        {
            CDynamicInt count = new CDynamicInt(cr2w, null, "");
            count.Read(file, size);

            base.Read(file, size, count.val);

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
            CDynamicInt count = new CDynamicInt(cr2w, null, "")
            {
                val = elements.Count
            };
            count.Write(file);

            base.Write(file);

            padding.Write(file);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var copy = base.Copy(context) as CPaddedBuffer<T>;

            //foreach (var element in elements)
            //{
            //    var ccopy = element.Copy(new CR2WCopyAction() { DestinationFile = context.DestinationFile, Parent = copy });
            //    if (ccopy is T copye)
            //        copy.elements.Add(copye);
            //}

            copy.padding = (CFloat)padding.Copy(context);

            return copy;
        }
    }

   
}