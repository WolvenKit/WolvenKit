using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiOnscreenVOPlayerController : gameuiWidgetGameController
	{
		private inkCompoundWidgetReference _subtitlesContainer;
		private CResourceAsyncReference<inkWidgetLibraryResource> _subtitlesLibraryResource;
		private CName _subtitlesRootName;
		private CArray<gameuiVOWithDelay> _audioVOList;

		[Ordinal(2)] 
		[RED("subtitlesContainer")] 
		public inkCompoundWidgetReference SubtitlesContainer
		{
			get => GetProperty(ref _subtitlesContainer);
			set => SetProperty(ref _subtitlesContainer, value);
		}

		[Ordinal(3)] 
		[RED("subtitlesLibraryResource")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> SubtitlesLibraryResource
		{
			get => GetProperty(ref _subtitlesLibraryResource);
			set => SetProperty(ref _subtitlesLibraryResource, value);
		}

		[Ordinal(4)] 
		[RED("subtitlesRootName")] 
		public CName SubtitlesRootName
		{
			get => GetProperty(ref _subtitlesRootName);
			set => SetProperty(ref _subtitlesRootName, value);
		}

		[Ordinal(5)] 
		[RED("audioVOList")] 
		public CArray<gameuiVOWithDelay> AudioVOList
		{
			get => GetProperty(ref _audioVOList);
			set => SetProperty(ref _audioVOList, value);
		}
	}
}
