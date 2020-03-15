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
    public class IdHandle : CVariable
    {
        public CUInt16 id;
        public CHandle handle;

        public IdHandle(CR2WFile cr2w) : base(cr2w)
        {
            id = new CUInt16(cr2w) { Name = "id" };
            handle = new CHandle(cr2w) { Name = "handle" };
        }

        public override void Read(BinaryReader file, uint size)
        {
            id.Read(file, 2);
            handle.Read(file, 2);
        }

        public override void Write(BinaryWriter file)
        {
            id.Write(file);
            handle.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new IdHandle(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (IdHandle)base.Copy(context);

            var.id = (CUInt16)id.Copy(context);
            var.handle = (CHandle)handle.Copy(context);
            

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>()
            {
                id,
                handle,
            };
        }

        public override string ToString()
        {
            return $"[{id.ToString()}]:{handle.ToString()}";
        }
    }
}