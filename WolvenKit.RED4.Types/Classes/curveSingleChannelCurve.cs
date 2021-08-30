using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class curveSingleChannelCurve : RedBaseClass
	{
		private CEnum<curveEInterpolationType> _interpolationType;
		private CEnum<curveESegmentsLinkType> _linkType;
		private DataBuffer _data;

		[Ordinal(0)] 
		[RED("interpolationType")] 
		public CEnum<curveEInterpolationType> InterpolationType
		{
			get => GetProperty(ref _interpolationType);
			set => SetProperty(ref _interpolationType, value);
		}

		[Ordinal(1)] 
		[RED("linkType")] 
		public CEnum<curveESegmentsLinkType> LinkType
		{
			get => GetProperty(ref _linkType);
			set => SetProperty(ref _linkType, value);
		}

		[Ordinal(2)] 
		[RED("data")] 
		public DataBuffer Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public curveSingleChannelCurve()
		{
			_interpolationType = new() { Value = Enums.curveEInterpolationType.EIT_Linear };
		}
	}
}
