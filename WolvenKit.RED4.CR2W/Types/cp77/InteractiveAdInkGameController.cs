using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InteractiveAdInkGameController : DeviceInkGameControllerBase
	{
		private inkVideoWidgetReference _processingVideo;
		private inkVideoWidgetReference _personalAd;
		private inkVideoWidgetReference _commonAd;
		private CFloat _fadeDuration;
		private CHandle<inkanimDefinition> _animFade;
		private inkanimPlaybackOptions _animOptions;
		private CBool _showAd;
		private CUInt32 _onShowAdListener;
		private CUInt32 _onShowVendorListener;

		[Ordinal(16)] 
		[RED("ProcessingVideo")] 
		public inkVideoWidgetReference ProcessingVideo
		{
			get => GetProperty(ref _processingVideo);
			set => SetProperty(ref _processingVideo, value);
		}

		[Ordinal(17)] 
		[RED("PersonalAd")] 
		public inkVideoWidgetReference PersonalAd
		{
			get => GetProperty(ref _personalAd);
			set => SetProperty(ref _personalAd, value);
		}

		[Ordinal(18)] 
		[RED("CommonAd")] 
		public inkVideoWidgetReference CommonAd
		{
			get => GetProperty(ref _commonAd);
			set => SetProperty(ref _commonAd, value);
		}

		[Ordinal(19)] 
		[RED("fadeDuration")] 
		public CFloat FadeDuration
		{
			get => GetProperty(ref _fadeDuration);
			set => SetProperty(ref _fadeDuration, value);
		}

		[Ordinal(20)] 
		[RED("animFade")] 
		public CHandle<inkanimDefinition> AnimFade
		{
			get => GetProperty(ref _animFade);
			set => SetProperty(ref _animFade, value);
		}

		[Ordinal(21)] 
		[RED("animOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get => GetProperty(ref _animOptions);
			set => SetProperty(ref _animOptions, value);
		}

		[Ordinal(22)] 
		[RED("showAd")] 
		public CBool ShowAd
		{
			get => GetProperty(ref _showAd);
			set => SetProperty(ref _showAd, value);
		}

		[Ordinal(23)] 
		[RED("onShowAdListener")] 
		public CUInt32 OnShowAdListener
		{
			get => GetProperty(ref _onShowAdListener);
			set => SetProperty(ref _onShowAdListener, value);
		}

		[Ordinal(24)] 
		[RED("onShowVendorListener")] 
		public CUInt32 OnShowVendorListener
		{
			get => GetProperty(ref _onShowVendorListener);
			set => SetProperty(ref _onShowVendorListener, value);
		}

		public InteractiveAdInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
