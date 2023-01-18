using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioShockwaveMetadata : audioEmitterMetadata
	{
		[Ordinal(1)] 
		[RED("explosionMetadataName")] 
		public CName ExplosionMetadataName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("thumpMetadataName")] 
		public CName ThumpMetadataName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("electroshockMetadataName")] 
		public CName ElectroshockMetadataName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("revealMetadataName")] 
		public CName RevealMetadataName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioShockwaveMetadata()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
