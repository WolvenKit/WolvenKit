using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVoiceTagGroup : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("voiceTags")] 
		public CArray<CName> VoiceTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public audioVoiceTagGroup()
		{
			VoiceTags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
