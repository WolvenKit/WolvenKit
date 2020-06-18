
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SCurveData : CVariable
    {
        public CFloat time;
		public CFloat value;
		public Vector controlPoint1;
		public Vector controlPoint2;
        public CUInt32 curveTypeL;
        public CUInt32 curveTypeR;
        //public CUInt16 unk3;
        //public CUInt16 unk4;
		

        public SCurveData(CR2WFile cr2w) : base(cr2w)
        {
        }


        public override CVariable Create(CR2WFile cr2w)
        {
            return new SCurveData(cr2w);
        }



        //[DataContract(Namespace = "")]
        //[REDMeta]
        //public class SCurveData : CVariable
        //{
        //    [RED("Curve Values", 142, 0)] public CArray<SCurveDataEntry> Curve_Values { get; set; }

        //    [RED("value type")] public ECurveValueType Value_type { get; set; }

        //    [RED("type")] public ECurveBaseType Type { get; set; }

        //    [RED("is looped")] public CBool Is_looped { get; set; }

        //    public SCurveData(CR2WFile cr2w) : base(cr2w) { }

        //    public override void Read(BinaryReader file, uint size) => base.Read(file, size);

        //    public override void Write(BinaryWriter file) => base.Write(file);

        //    public override CVariable Create(CR2WFile cr2w) => new SCurveData(cr2w);

        //}
    }
}
