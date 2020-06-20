
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
    //[REDMeta(EREDMetaInfo.REDStruct)]
    //public class SCurveData : CVariable
    //{
    //    [RED] public CFloat time { get; set; }
    //    [RED] public CFloat value { get; set; }
    //    [RED] public Vector controlPoint1 { get; set; }
    //    [RED] public Vector controlPoint2 { get; set; }
    //    [RED] public CUInt32 curveTypeL { get; set; }
    //    [RED] public CUInt32 curveTypeR { get; set; }
    //    //public CUInt16 unk3;
    //    //public CUInt16 unk4;


    //    public SCurveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
    //    {
    //    }


    //    public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name)
    //    {
    //        return new SCurveData(cr2w);
    //    }
    //}



    [DataContract(Namespace = "")]
    [REDMeta]
    public class SCurveData : CVariable
    {
        [RED("Curve Values", 142, 0)] public CArray<SCurveDataEntry> Curve_Values { get; set; }

        [RED("value type")] public CEnum<ECurveValueType> Value_type { get; set; }

        [RED("type")] public CEnum<ECurveBaseType> Type { get; set; }

        [RED("is looped")] public CBool Is_looped { get; set; }

        public SCurveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void Read(BinaryReader file, uint size) => base.Read(file, size);

        public override void Write(BinaryWriter file) => base.Write(file);

        public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCurveData(cr2w, parent, name);

    }
}
