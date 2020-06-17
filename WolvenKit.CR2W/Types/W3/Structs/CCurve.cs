using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta]
    public class CCurve : CObject
    {
        [RED("color")] public CColor Color { get; set; }

        [RED("dataBaseType")] public ECurveBaseType DataBaseType { get; set; }

        [RED("data.m_loop")] public CBool Data_m_loop { get; set; }

        public CBufferUInt32<SCurveData> curveData { get; set; }

        public CCurve(CR2WFile cr2w) : base(cr2w)
        {
            curveData = new CBufferUInt32<SCurveData>(cr2w, _ => new SCurveData(_)) { Name = "curveData" };

        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            curveData.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            curveData.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CCurve(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CCurve)base.Copy(context);

            var.curveData = (CBufferUInt32<SCurveData>)curveData.Copy(context);

            return var;
        }
    }
}