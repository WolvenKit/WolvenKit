using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class localizationPersistenceLocDataMapEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("langCode")] 
		public CName LangCode
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("onscreensPath")] 
		public CResourceAsyncReference<JsonResource> OnscreensPath
		{
			get => GetPropertyValue<CResourceAsyncReference<JsonResource>>();
			set => SetPropertyValue<CResourceAsyncReference<JsonResource>>(value);
		}

		[Ordinal(2)] 
		[RED("subtitlePath")] 
		public CResourceAsyncReference<JsonResource> SubtitlePath
		{
			get => GetPropertyValue<CResourceAsyncReference<JsonResource>>();
			set => SetPropertyValue<CResourceAsyncReference<JsonResource>>(value);
		}
	}
}
