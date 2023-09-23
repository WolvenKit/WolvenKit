using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VideoCarouselData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("videoTitleKey")] 
		public CName VideoTitleKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("videoDescriptionKey")] 
		public CName VideoDescriptionKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("videoResPath")] 
		public redResourceReferenceScriptToken VideoResPath
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		public VideoCarouselData()
		{
			VideoResPath = new redResourceReferenceScriptToken();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
