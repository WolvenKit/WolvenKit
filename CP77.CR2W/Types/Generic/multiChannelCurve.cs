using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using CP77.CR2W.Reflection;
using FastMember;

namespace CP77.CR2W.Types
{
    /// <summary>
    /// A pointer to a chunk within the same cr2w file.
    /// </summary>
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class multiChannelCurve<T> : CVariable, ICurveDataAccessor where T : CVariable
    {
        public enum EInterPolationType
        {
            Constant,
            Linear, 
            BezierQuadratic,
            BezierCubic,
            Hermite
        }

        public enum ELinkType
        {
            Normal,
            Smooth,
            SmoothSymmertric
        }

        public multiChannelCurve(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            //NumChannels = new CUInt32(cr2w, this, nameof(NumChannels));
            InterPolationType = new CEnum<EInterPolationType>(cr2w, this, nameof(InterPolationType));
            LinkType = new CEnum<ELinkType>(cr2w, this, nameof(LinkType));
            Alignment = new CUInt32(cr2w, this, nameof(Alignment));
            Data = new CByteArray(cr2w, this, nameof(Data));
        }


        [Ordinal(1)] [REDBuffer] public CUInt32 NumChannels { get; set; }
        [Ordinal(2)] [REDBuffer(true)] public CEnum<EInterPolationType> InterPolationType { get; set; }
        [Ordinal(3)] [REDBuffer(true)] public CEnum<ELinkType> LinkType { get; set; }
        [Ordinal(4)] [REDBuffer(true)] public CUInt32 Alignment { get; set; }
        [Ordinal(5)] [REDBuffer(true)] public CByteArray Data { get; set; }

        public string Elementtype { get; set; }

        //private List<CurvePoint<T>> Elements { get; set; } = new();

        public override string REDType => $"multiChannelCurve:{Elementtype}";

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            var interPolationTypeByte = (int)file.ReadByte();
            InterPolationType.WrappedEnum = (EInterPolationType) interPolationTypeByte;

            var linkTypeByte = (int)file.ReadByte();
            LinkType.WrappedEnum = (ELinkType) linkTypeByte;

            Alignment.Read(file, 4);
            Data.Read(file, 0);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            file.Write((byte)InterPolationType.WrappedEnum);
            file.Write((byte)LinkType.WrappedEnum);

            Alignment.Write(file);
            Data.Write(file);
        }

        //public override List<IEditableVariable> GetEditableVariables()
        //{
        //    return Elements.Cast<IEditableVariable>().ToList();
        //}
    }


}
