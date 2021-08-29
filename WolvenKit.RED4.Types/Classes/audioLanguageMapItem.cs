using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioLanguageMapItem : audioAudioMetadata
	{
		private audioLanguage _language;

		[Ordinal(1)] 
		[RED("language")] 
		public audioLanguage Language
		{
			get => GetProperty(ref _language);
			set => SetProperty(ref _language, value);
		}
	}
}
