using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using WolvenKit.RED4.CR2W.Types;

namespace WolvenKit.RED4.CR2W.Types
{
    /// <summary>
    /// A pointer to a chunk within the same cr2w file.
    /// </summary>
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class multiChannelCurve<T> : CVariable, ICurveDataAccessor where T : CVariable
    {


        public multiChannelCurve(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            //NumChannels = new CUInt32(cr2w, this, nameof(NumChannels));
            InterPolationType = new CEnum<Enums.EInterPolationType>(cr2w, this, nameof(InterPolationType));
            LinkType = new CEnum<Enums.EChannelLinkType>(cr2w, this, nameof(LinkType));
            Alignment = new CUInt32(cr2w, this, nameof(Alignment));
            Data = new CByteArray(cr2w, this, nameof(Data));
        }


        [Ordinal(1)] [REDBuffer] public CUInt32 NumChannels { get; set; }
        [Ordinal(2)] [REDBuffer(true)] public CEnum<Enums.EInterPolationType> InterPolationType { get; set; }
        [Ordinal(3)] [REDBuffer(true)] public CEnum<Enums.EChannelLinkType> LinkType { get; set; }
        [Ordinal(4)] [REDBuffer(true)] public CUInt32 Alignment { get; set; }
        [Ordinal(5)] [REDBuffer(true)] public CByteArray Data { get; set; }

        public string Elementtype => REDReflection.GetREDTypeString(typeof(T));

        //private List<CurvePoint<T>> Elements { get; set; } = new();

        public override string REDType => REDReflection.GetREDTypeString(GetType());

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            var interPolationTypeByte = (int)file.ReadByte();
            InterPolationType.Value = (Enums.EInterPolationType) interPolationTypeByte;

            var linkTypeByte = (int)file.ReadByte();
            LinkType.Value = (Enums.EChannelLinkType) linkTypeByte;

            Alignment.Read(file, 4);
            Data.Read(file, 0);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            file.Write((byte)InterPolationType.Value);
            file.Write((byte)LinkType.Value);

            Alignment.Write(file);
            Data.Write(file);
        }

        //public override List<IEditableVariable> GetEditableVariables()
        //{
        //    return Elements.Cast<IEditableVariable>().ToList();
        //}
    }


}
