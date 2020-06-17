
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
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
            time = new CFloat(cr2w) { Name = "x" };
			value = new CFloat(cr2w){ Name = "y" };
            controlPoint1 = new Vector(cr2w){ Name = "controlPoint1" };
            controlPoint2 = new Vector(cr2w){ Name = "controlPoint2" };
            curveTypeL = new CUInt32(cr2w) { Name = "curveTypeL" };
            curveTypeR = new CUInt32(cr2w) { Name = "curveTypeR" };
            //unk3 = new CUInt16(cr2w) { Name = "curveTypeL" };
            //unk4 = new CUInt16(cr2w) { Name = "curveTypeR" };
        }

        public override void Read(BinaryReader file, uint size)
        {
            time.Read(file,size);
			value.Read(file,size);
            controlPoint1.Read(file,size);
            controlPoint2.Read(file,size);
            curveTypeL.Read(file, size);
            curveTypeR.Read(file, size);
            //unk3.Read(file, size);
            //unk4.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            time.Write(file);
            value.Write(file);
            controlPoint1.Write(file);
            controlPoint2.Write(file);
            curveTypeL.Write(file);
            curveTypeR.Write(file);
            //unk3.Write(file);
            //unk4.Write(file);
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
