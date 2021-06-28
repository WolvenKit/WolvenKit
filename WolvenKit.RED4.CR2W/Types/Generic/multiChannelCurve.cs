using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.RED4.CR2W.Types;

namespace WolvenKit.RED4.CR2W.Types
{
    /// <summary>
    /// A pointer to a chunk within the same cr2w file.
    /// </summary>
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class multiChannelCurve<T> : CVariable, IMultiChannelCurve where T : CVariable
    {


        public multiChannelCurve(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {

        }


        private CUInt32 _numChannels;
        [Ordinal(1)]
        [REDBuffer(true)]
        public CUInt32 NumChannels
        {
            get => GetProperty(ref _numChannels);
            set => SetProperty(ref _numChannels, value);
        }

        private CEnum<Enums.EInterPolationType> _interPolationType;
        [Ordinal(2)]
        [REDBuffer(true)]
        public CEnum<Enums.EInterPolationType> InterPolationType
        {
            get => GetProperty(ref _interPolationType);
            set => SetProperty(ref _interPolationType, value);
        }

        private CEnum<Enums.EChannelLinkType> _linkType;
        [Ordinal(3)]
        [REDBuffer(true)]
        public CEnum<Enums.EChannelLinkType> LinkType
        {
            get => GetProperty(ref _linkType);
            set => SetProperty(ref _linkType, value);
        }

        private CUInt32 _alignment;
        [Ordinal(4)]
        [REDBuffer(true)]
        public CUInt32 Alignment
        {
            get => GetProperty(ref _alignment);
            set => SetProperty(ref _alignment, value);
        }

        private CByteArray _data;
        [Ordinal(5)]
        [REDBuffer(true)]
        public CByteArray Data
        {
            get => GetProperty(ref _data);
            set => SetProperty(ref _data, value);
        }

        public string Elementtype => REDReflection.GetREDTypeString(typeof(T));

        //private List<CurvePoint<T>> Elements { get; set; } = new();

        public override string REDType => REDReflection.GetREDTypeString(GetType());

        public override void Read(BinaryReader file, uint size)
        {
            NumChannels.Read(file, size);

            var interPolationTypeByte = (int)file.ReadByte();
            InterPolationType.Value = (Enums.EInterPolationType) interPolationTypeByte;

            var linkTypeByte = (int)file.ReadByte();
            LinkType.Value = (Enums.EChannelLinkType) linkTypeByte;

            Alignment.Read(file, 4);
            Data.Read(file, 0);
        }

        public override void Write(BinaryWriter file)
        {
            NumChannels.Write(file);

            file.Write((byte)InterPolationType.Value);
            file.Write((byte)LinkType.Value);

            Alignment.Write(file);
            Data.Write(file);
        }
    }


}
