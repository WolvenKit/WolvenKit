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

        public EntityHandle(CR2WFile cr2w) : base(cr2w)
        {
            id = new CUInt16(cr2w) { Name = "id" };
            guid = new CGUID(cr2w) { Name = "guid" };
        }

        public override void Read(BinaryReader file, uint size)
        {
            id.Read(file, 2);
            guid.Read(file, 2);
        }

        public override void Write(BinaryWriter file)
        {
            id.Write(file);
            guid.Write(file);
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
            

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>()
            {
                id,
                guid,
            };
        }

        public override string ToString()
        {
            return $"[{id.ToString()}]:{guid.ToString()}";
        }
    }
}