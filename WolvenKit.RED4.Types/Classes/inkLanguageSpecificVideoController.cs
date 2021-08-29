using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkLanguageSpecificVideoController : inkWidgetLogicController
	{
		private CBool _isLooped;
		private CResourceAsyncReference<Bink> _specificVideoForLanguage;
		private CArray<CEnum<inkLanguageId>> _languages;
		private CResourceAsyncReference<Bink> _fallbackVideo;

		[Ordinal(1)] 
		[RED("isLooped")] 
		public CBool IsLooped
		{
			get => GetProperty(ref _isLooped);
			set => SetProperty(ref _isLooped, value);
		}

		[Ordinal(2)] 
		[RED("specificVideoForLanguage")] 
		public CResourceAsyncReference<Bink> SpecificVideoForLanguage
		{
			get => GetProperty(ref _specificVideoForLanguage);
			set => SetProperty(ref _specificVideoForLanguage, value);
		}

		[Ordinal(3)] 
		[RED("languages")] 
		public CArray<CEnum<inkLanguageId>> Languages
		{
			get => GetProperty(ref _languages);
			set => SetProperty(ref _languages, value);
		}

		[Ordinal(4)] 
		[RED("fallbackVideo")] 
		public CResourceAsyncReference<Bink> FallbackVideo
		{
			get => GetProperty(ref _fallbackVideo);
			set => SetProperty(ref _fallbackVideo, value);
		}
	}
}
