using FastMember;
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
    public class SCurveData : CVariable
    {
        [Ordinal(1)] [RED("Curve Values", 142, 0)] public CArray<SCurveDataEntry> Curve_Values { get; set; }

        [Ordinal(2)] [RED("value type")] public CEnum<ECurveValueType> Value_type { get; set; }

        [Ordinal(3)] [RED("type")] public CEnum<ECurveBaseType> Type { get; set; }

        [Ordinal(4)] [RED("is looped")] public CBool Is_looped { get; set; }


        public SCurveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void Read(BinaryReader file, uint size) => base.Read(file, size);

        public override void Write(BinaryWriter file) => base.Write(file);

        public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCurveData(cr2w, parent, name);

    }

    [DataContract(Namespace = "")]
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SCurveBufferData : CVariable
    {

        [REDBuffer] public CFloat time { get; set; }
        [REDBuffer] public SVector4D controlPoint1 { get; set; }
        [REDBuffer] public SVector4D controlPoint2 { get; set; }
        [REDBuffer] public CFloat value { get; set; }
        [REDBuffer] public CUInt16 curveTypeL { get; set; }
        [REDBuffer] public CUInt16 curveTypeR { get; set; }
        [REDBuffer] public CUInt32 unk1 { get; set; }


        public SCurveBufferData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }


        public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCurveBufferData(cr2w, parent, name);

    }
}
