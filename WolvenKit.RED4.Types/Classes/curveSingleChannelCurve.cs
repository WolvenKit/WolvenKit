using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class curveSingleChannelCurve : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("interpolationType")] 
		public CEnum<curveEInterpolationType> InterpolationType
		{
			get => GetPropertyValue<CEnum<curveEInterpolationType>>();
			set => SetPropertyValue<CEnum<curveEInterpolationType>>(value);
		}

		[Ordinal(1)] 
		[RED("linkType")] 
		public CEnum<curveESegmentsLinkType> LinkType
		{
			get => GetPropertyValue<CEnum<curveESegmentsLinkType>>();
			set => SetPropertyValue<CEnum<curveESegmentsLinkType>>(value);
		}

		[Ordinal(2)] 
		[RED("data")] 
		public DataBuffer Data
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		public curveSingleChannelCurve()
		{
			InterpolationType = Enums.curveEInterpolationType.EIT_Linear;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
