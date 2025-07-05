using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAdvertMetadata : audioEmitterMetadata
	{
		[Ordinal(1)] 
		[RED("advertSoundNames")] 
		public CArray<CName> AdvertSoundNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("minSilenceTime")] 
		public CFloat MinSilenceTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("maxSilenceTime")] 
		public CFloat MaxSilenceTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("minDistance")] 
		public CFloat MinDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("filter")] 
		public CEnum<audioAdvertIndoorFilter> Filter
		{
			get => GetPropertyValue<CEnum<audioAdvertIndoorFilter>>();
			set => SetPropertyValue<CEnum<audioAdvertIndoorFilter>>(value);
		}

		public audioAdvertMetadata()
		{
			AdvertSoundNames = new();
			MinSilenceTime = 1.000000F;
			MaxSilenceTime = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
