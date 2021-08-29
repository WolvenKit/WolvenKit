namespace WolvenKit.RED4.Types
{
    [RED("multiChannelCurve")]
    public class MultiChannelCurve<T> : IRedPrimitive where T : IRedType
    {
        /*private CUInt32 _numChannels;
        private CEnum<Enums.EInterPolationType> _interPolationType;
        private CEnum<Enums.EChannelLinkType> _linkType;
        private CUInt32 _alignment;
        private CByteArray _data;


        [Ordinal(1)]
        [REDBuffer(true)]
        public CUInt32 NumChannels
        {
            get => GetProperty(ref _numChannels);
            set => SetProperty(ref _numChannels, value);
        }

        [Ordinal(2)]
        [REDBuffer(true)]
        public CEnum<Enums.EInterPolationType> InterPolationType
        {
            get => GetProperty(ref _interPolationType);
            set => SetProperty(ref _interPolationType, value);
        }

        [Ordinal(3)]
        [REDBuffer(true)]
        public CEnum<Enums.EChannelLinkType> LinkType
        {
            get => GetProperty(ref _linkType);
            set => SetProperty(ref _linkType, value);
        }

        [Ordinal(4)]
        [REDBuffer(true)]
        public CUInt32 Alignment
        {
            get => GetProperty(ref _alignment);
            set => SetProperty(ref _alignment, value);
        }

        [Ordinal(5)]
        [REDBuffer(true)]
        public CByteArray Data
        {
            get => GetProperty(ref _data);
            set => SetProperty(ref _data, value);
        }*/
    }
}
