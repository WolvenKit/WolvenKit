using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class localizationPersistenceLocDataMapEntry : RedBaseClass
	{
		private CName _langCode;
		private CResourceAsyncReference<JsonResource> _onscreensPath;
		private CResourceAsyncReference<JsonResource> _subtitlePath;

		[Ordinal(0)] 
		[RED("langCode")] 
		public CName LangCode
		{
			get => GetProperty(ref _langCode);
			set => SetProperty(ref _langCode, value);
		}

		[Ordinal(1)] 
		[RED("onscreensPath")] 
		public CResourceAsyncReference<JsonResource> OnscreensPath
		{
			get => GetProperty(ref _onscreensPath);
			set => SetProperty(ref _onscreensPath, value);
		}

		[Ordinal(2)] 
		[RED("subtitlePath")] 
		public CResourceAsyncReference<JsonResource> SubtitlePath
		{
			get => GetProperty(ref _subtitlePath);
			set => SetProperty(ref _subtitlePath, value);
		}
	}
}
