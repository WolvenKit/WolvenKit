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
    public class CNode : CObject
    {
        [RED("tags")] public TagList Tags { get; set; }

        [RED("transform")] public EngineTransform Transform { get; set; }

        [RED("transformParent")] public CPtr<CHardAttachment> TransformParent { get; set; }

        [RED("guid")] public CGUID Guid { get; set; }

        [REDBuffer] public CArray<IAttachment> AttachmentsReference { get; set; } //FIXME? correct?
        [REDBuffer] public CArray<IAttachment> AttachmentsChild { get; set; }    //FIXME? correct?

        public CNode(CR2WFile cr2w) : base(cr2w)
        {


        }

        public override void Read(BinaryReader file, uint size) => base.Read(file, size);

        public override void Write(BinaryWriter file) => base.Write(file);

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CNode(cr2w);
        }

        
    }
}