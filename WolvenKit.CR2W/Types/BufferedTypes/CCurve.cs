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

        [REDBuffer] public CBufferUInt32<SCurveData> curveData { get; set; }

        public CCurve(CR2WFile cr2w) : base(cr2w)
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
            return new CCurve(cr2w);
        }

    }
}