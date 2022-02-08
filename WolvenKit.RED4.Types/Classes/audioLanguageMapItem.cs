using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioLanguageMapItem : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("language")] 
		public audioLanguage Language
		{
			get => GetPropertyValue<audioLanguage>();
			set => SetPropertyValue<audioLanguage>(value);
		}

		public audioLanguageMapItem()
		{
			Language = new();
		}
	}
}
