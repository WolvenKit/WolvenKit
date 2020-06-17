using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta]
    public class CBehaviorGraphContainerNode : CBehaviorGraphNode
    {
        [RED("mimicInputs", 2, 0)] public CArray<CName> MimicInputs { get; set; }

        [RED("vectorValueInputs", 2, 0)] public CArray<CName> VectorValueInputs { get; set; }

        [REDBuffer] public CBufferVLQ<CHandle<CBehaviorVariable>> Inputnodes { get; set; }
        [REDBuffer] public CBufferVLQ<CName> Unk1 { get; set; }
        [REDBuffer] public CBufferVLQ<CName> Unk2 { get; set; }
        [REDBuffer] public CHandle<CBehaviorVariable> Outputnode { get; set; }

        public CBehaviorGraphContainerNode(CR2WFile cr2w) :
            base(cr2w)
        {


        }

        public override void Read(BinaryReader file, uint size) => base.Read(file, size);

        public override void Write(BinaryWriter file) => base.Write(file);

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CBehaviorGraphContainerNode(cr2w);
        }


    }
}