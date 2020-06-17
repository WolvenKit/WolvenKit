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
        public CName handlename;
        public CHandle handle;

        public IdHandle(CR2WFile cr2w) : base(cr2w)
        {
            handlename = new CName(cr2w) { Name = "handlename" };
            handle = new CHandle(cr2w) { Name = "handle" };
        }

        public override void Read(BinaryReader file, uint size)
        {
            handlename.Read(file, 2);
            handle.Read(file, 2);
        }

        public override void Write(BinaryWriter file)
        {
            handlename.Write(file);
            handle.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new IdHandle(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (IdHandle)base.Copy(context);

            var.handlename = (CName)handlename.Copy(context);
            var.handle = (CHandle)handle.Copy(context);
            

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>()
            {
                handlename,
                handle,
            };
        }

        public override string ToString()
        {
            return $"[{handlename.ToString()}]:{handle.ToString()}";
        }
    }
}