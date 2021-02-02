using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using CP77.CR2W.Reflection;

namespace CP77.CR2W.Types
{
    /// <summary>
    /// A pointer to a chunk within the same cr2w file.
    /// </summary>
    [REDMeta]
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
            NumChannels = new CUInt32(cr2w, this, nameof(NumChannels));
            InterPolationType = new CEnum<EInterPolationType>(cr2w, this, nameof(InterPolationType));
            LinkType = new CEnum<ELinkType>(cr2w, this, nameof(LinkType));
            Alignment = new CUInt32(cr2w, this, nameof(Alignment));
            Data = new CByteArray(cr2w, this, nameof(Data));
        }

        public CUInt32 NumChannels;
        public CEnum<EInterPolationType> InterPolationType;
        public CEnum<ELinkType> LinkType;
        public CUInt32 Alignment;
        public CByteArray Data;

        public string Elementtype { get; set; }

        private List<CurvePoint<T>> Elements { get; set; } = new();

        public override void Read(BinaryReader file, uint size)
        {
            var pos = file.BaseStream.Position;

            NumChannels.Read(file, 4);

            var interPolationTypeByte = (int)file.ReadByte();
            InterPolationType.WrappedEnum = (EInterPolationType) interPolationTypeByte;

            var linkTypeByte = (int)file.ReadByte();
            LinkType.WrappedEnum = (ELinkType) linkTypeByte;

            Alignment.Read(file, 4);
            Data.Read(file, 0);
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return Elements.Cast<IEditableVariable>().ToList();
        }
    }


}
