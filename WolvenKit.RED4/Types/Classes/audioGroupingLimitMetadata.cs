using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioGroupingLimitMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("limit")] 
		public CFloat Limit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioGroupingLimitMetadata()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
