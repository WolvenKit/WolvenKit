using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioNpcGunChoirSettings : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("voices")] 
		public CArray<CName> Voices
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public audioNpcGunChoirSettings()
		{
			Voices = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
