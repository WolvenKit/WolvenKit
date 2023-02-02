using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioPhysicalPropSettings : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("shockwaveSound")] 
		public CName ShockwaveSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("damagedSound")] 
		public CName DamagedSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("destroyedSound")] 
		public CName DestroyedSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("materialOverrides")] 
		public CArray<CName> MaterialOverrides
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public audioPhysicalPropSettings()
		{
			MaterialOverrides = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
