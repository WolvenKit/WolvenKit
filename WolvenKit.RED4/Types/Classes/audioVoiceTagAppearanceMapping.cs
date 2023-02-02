using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVoiceTagAppearanceMapping : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("mappings")] 
		public CArray<audioVoiceTagAppearanceGroup> Mappings
		{
			get => GetPropertyValue<CArray<audioVoiceTagAppearanceGroup>>();
			set => SetPropertyValue<CArray<audioVoiceTagAppearanceGroup>>(value);
		}

		public audioVoiceTagAppearanceMapping()
		{
			Mappings = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
