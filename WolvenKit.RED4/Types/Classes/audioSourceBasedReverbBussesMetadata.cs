using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioSourceBasedReverbBussesMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("exterior")] 
		public CName Exterior
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("interiorLarge")] 
		public CName InteriorLarge
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("interiorMedium")] 
		public CName InteriorMedium
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("interiorSmall")] 
		public CName InteriorSmall
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioSourceBasedReverbBussesMetadata()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
