using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiOnscreenVOPlayerController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("subtitlesContainer")] 
		public inkCompoundWidgetReference SubtitlesContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("subtitlesLibraryResource")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> SubtitlesLibraryResource
		{
			get => GetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>(value);
		}

		[Ordinal(4)] 
		[RED("subtitlesRootName")] 
		public CName SubtitlesRootName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("audioVOList")] 
		public CArray<gameuiVOWithDelay> AudioVOList
		{
			get => GetPropertyValue<CArray<gameuiVOWithDelay>>();
			set => SetPropertyValue<CArray<gameuiVOWithDelay>>(value);
		}

		public gameuiOnscreenVOPlayerController()
		{
			SubtitlesContainer = new inkCompoundWidgetReference();
			AudioVOList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
