using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta]
    public class CComponent : CNode
    {
        [RED("name")] public CString Name { get; set; }

        [RED("isStreamed")] public CBool IsStreamed { get; set; }

        public CComponent(CR2WFile cr2w) : base(cr2w)
        {

        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CComponent(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CComponent) base.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(base.GetEditableVariables());

            return list;
        }
    }
}