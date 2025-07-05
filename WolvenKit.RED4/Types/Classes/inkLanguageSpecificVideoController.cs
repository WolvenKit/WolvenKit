using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkLanguageSpecificVideoController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("isLooped")] 
		public CBool IsLooped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("specificVideoForLanguage")] 
		public CResourceAsyncReference<Bink> SpecificVideoForLanguage
		{
			get => GetPropertyValue<CResourceAsyncReference<Bink>>();
			set => SetPropertyValue<CResourceAsyncReference<Bink>>(value);
		}

		[Ordinal(3)] 
		[RED("languages")] 
		public CArray<CEnum<inkLanguageId>> Languages
		{
			get => GetPropertyValue<CArray<CEnum<inkLanguageId>>>();
			set => SetPropertyValue<CArray<CEnum<inkLanguageId>>>(value);
		}

		[Ordinal(4)] 
		[RED("fallbackVideo")] 
		public CResourceAsyncReference<Bink> FallbackVideo
		{
			get => GetPropertyValue<CResourceAsyncReference<Bink>>();
			set => SetPropertyValue<CResourceAsyncReference<Bink>>(value);
		}

		public inkLanguageSpecificVideoController()
		{
			Languages = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
