
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
		public CQuaternion controlPoint1;
		public CQuaternion controlPoint2;
        public CUInt32 curveTypeL;
        public CUInt32 curveTypeR;
        //public CUInt16 unk3;
        //public CUInt16 unk4;
		

        public SCurveData(CR2WFile cr2w) : base(cr2w)
        {
            time = new CFloat(cr2w) { Name = "x" };
			value = new CFloat(cr2w){ Name = "y" };
            controlPoint1 = new CQuaternion(cr2w){ Name = "controlPoint1" };
            controlPoint2 = new CQuaternion(cr2w){ Name = "controlPoint2" };
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

        public override CVariable Copy(CR2WCopyAction context)
        {
                var var = (SCurveData)base.Copy(context);
            
                var.time = (CFloat)time.Copy(context);
				var.value = (CFloat)value.Copy(context);
				var.controlPoint1 = (CQuaternion)controlPoint1.Copy(context);
				var.controlPoint1 = (CQuaternion)controlPoint2.Copy(context);
				var.curveTypeL = (CUInt32)curveTypeL.Copy(context);
				var.curveTypeR = (CUInt32)curveTypeR.Copy(context);
				//var.unk3 = (CUInt16)unk3.Copy(context);
				//var.unk4 = (CUInt16)unk4.Copy(context);
            
                return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>()
            {
                time,
				value,
				controlPoint1,
				controlPoint2,
                curveTypeL,
                curveTypeR,
                //unk3,
                //unk4,
            };
            return list;
        }
    }
}
