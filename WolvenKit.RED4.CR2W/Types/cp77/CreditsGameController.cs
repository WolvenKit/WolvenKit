using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CreditsGameController : gameuiCreditsController
	{
		private inkCompoundWidgetReference _videoContainer;
		private inkImageWidgetReference _sceneTexture;
		private inkVideoWidgetReference _backgroundVideo;
		private inkVideoWidgetReference _binkVideo;
		private CArray<gameuiBinkResource> _binkVideos;
		private CInt32 _currentBinkVideo;
		private inkVideoWidgetSummary _videoSummary;
		private CBool _isDataSet;

		[Ordinal(26)] 
		[RED("videoContainer")] 
		public inkCompoundWidgetReference VideoContainer
		{
			get => GetProperty(ref _videoContainer);
			set => SetProperty(ref _videoContainer, value);
		}

		[Ordinal(27)] 
		[RED("sceneTexture")] 
		public inkImageWidgetReference SceneTexture
		{
			get => GetProperty(ref _sceneTexture);
			set => SetProperty(ref _sceneTexture, value);
		}

		[Ordinal(28)] 
		[RED("backgroundVideo")] 
		public inkVideoWidgetReference BackgroundVideo
		{
			get => GetProperty(ref _backgroundVideo);
			set => SetProperty(ref _backgroundVideo, value);
		}

		[Ordinal(29)] 
		[RED("binkVideo")] 
		public inkVideoWidgetReference BinkVideo
		{
			get => GetProperty(ref _binkVideo);
			set => SetProperty(ref _binkVideo, value);
		}

		[Ordinal(30)] 
		[RED("binkVideos")] 
		public CArray<gameuiBinkResource> BinkVideos
		{
			get => GetProperty(ref _binkVideos);
			set => SetProperty(ref _binkVideos, value);
		}

		[Ordinal(31)] 
		[RED("currentBinkVideo")] 
		public CInt32 CurrentBinkVideo
		{
			get => GetProperty(ref _currentBinkVideo);
			set => SetProperty(ref _currentBinkVideo, value);
		}

		[Ordinal(32)] 
		[RED("videoSummary")] 
		public inkVideoWidgetSummary VideoSummary
		{
			get => GetProperty(ref _videoSummary);
			set => SetProperty(ref _videoSummary, value);
		}

		[Ordinal(33)] 
		[RED("isDataSet")] 
		public CBool IsDataSet
		{
			get => GetProperty(ref _isDataSet);
			set => SetProperty(ref _isDataSet, value);
		}

		public CreditsGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
