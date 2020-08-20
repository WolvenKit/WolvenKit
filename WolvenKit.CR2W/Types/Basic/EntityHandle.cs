using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;
using System.Linq;
using System.Globalization;
using System.Runtime.Serialization;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class EntityHandle : CVariable
    {
        public CUInt16 id;
        public CGUID guid;
        public CBytes unk1;

        public EntityHandle(CR2WFile cr2w) : base(cr2w)
        {
            id = new CUInt16(cr2w) { Name = "id" };
            guid = new CGUID(cr2w) { Name = "guid" };
            unk1 = new CBytes(cr2w) { Name = "unk1", Bytes = Array.Empty<byte>() };
        }

        public override void Read(BinaryReader file, uint size)
        {
            id.Read(file, 2);
            guid.Read(file, 16);
            if (size - 18 > 0)
            {
                unk1.Read(file, size - 18);
            }
                
        }

        public override void Write(BinaryWriter file)
        {
            id.Write(file);
            guid.Write(file);
            unk1.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new EntityHandle(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (EntityHandle)base.Copy(context);

            var.id = (CUInt16)id.Copy(context);
            var.guid = (CGUID)guid.Copy(context);
            var.unk1 = (CBytes)unk1.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>()
            {
                id,
                guid,
                unk1,
            };
        }

        public override string ToString()
        {
            return $"[{id.ToString()}]:{guid.ToString()}";
        }
    }
}