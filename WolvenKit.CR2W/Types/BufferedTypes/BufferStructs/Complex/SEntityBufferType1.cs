using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types.Utils
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SEntityBufferType1 : CVariable
    {
        [RED] public CName ComponentName { get; set; }
        [RED] public CGUID Guid { get; set; }
        [RED] public CByteArray2 Buffer { get; set; }

        public SEntityBufferType1(CR2WFile cr2w) : base(cr2w)
        {
            ComponentName = new CName(cr2w)
            {
                Name = "Name",
            };
            Guid = new CGUID(cr2w)
            {
                Name = "GUID"
            };
            Buffer = new CByteArray2(cr2w)
            {
                Name = "Data",
            };
        }

        public bool CanRead(BinaryReader file)
        {
            ComponentName.Read(file, 2);
            return !string.IsNullOrEmpty(ComponentName.Value); // if empty return 0
        }

        /// <summary>
        /// Always call CanRead before calling this method! // FIXME
        /// </summary>
        /// <param name="file"></param>
        /// <param name="size"></param>
        public override void Read(BinaryReader file , uint size)
        {
            if (!string.IsNullOrEmpty(ComponentName.Value))
            {
                Guid.Read(file, 16);
                Buffer.Read(file, size);
            }
        }

        public override void Write(BinaryWriter file)
        {
            ComponentName.Write(file);
            if (!string.IsNullOrEmpty(ComponentName.Value))
            {
                Guid.Write(file);
                Buffer.Write(file);
            }
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new SEntityBufferType1(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (SEntityBufferType1)base.Copy(context);

            var.ComponentName = (CName)ComponentName.Copy(context);
            var.Guid = (CGUID)Guid.Copy(context);
            var.Buffer = (CByteArray2)Buffer.Copy(context);

            return var;
        }

        public override string ToString()
        {
            return ComponentName.Value;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var editableVars = new List<IEditableVariable>()
            {
                ComponentName,
            };
            if (!string.IsNullOrEmpty(ComponentName.Value))
            {
                editableVars.Add(Guid);
                editableVars.Add(Buffer);
            }

            return editableVars;
        }
    }
}
