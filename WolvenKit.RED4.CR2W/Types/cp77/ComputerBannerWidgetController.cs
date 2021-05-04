using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ComputerBannerWidgetController : DeviceInkLogicControllerBase
	{
		private inkTextWidgetReference _titleWidget;
		private inkTextWidgetReference _textContentWidget;
		private inkVideoWidgetReference _videoContentWidget;
		private inkImageWidgetReference _imageContentWidget;
		private inkWidgetReference _bannerButtonWidget;
		private SBannerWidgetPackage _bannerData;
		private redResourceReferenceScriptToken _lastPlayedVideo;

		[Ordinal(5)] 
		[RED("titleWidget")] 
		public inkTextWidgetReference TitleWidget
		{
			get => GetProperty(ref _titleWidget);
			set => SetProperty(ref _titleWidget, value);
		}

		[Ordinal(6)] 
		[RED("textContentWidget")] 
		public inkTextWidgetReference TextContentWidget
		{
			get => GetProperty(ref _textContentWidget);
			set => SetProperty(ref _textContentWidget, value);
		}

		[Ordinal(7)] 
		[RED("videoContentWidget")] 
		public inkVideoWidgetReference VideoContentWidget
		{
			get => GetProperty(ref _videoContentWidget);
			set => SetProperty(ref _videoContentWidget, value);
		}

		[Ordinal(8)] 
		[RED("imageContentWidget")] 
		public inkImageWidgetReference ImageContentWidget
		{
			get => GetProperty(ref _imageContentWidget);
			set => SetProperty(ref _imageContentWidget, value);
		}

		[Ordinal(9)] 
		[RED("bannerButtonWidget")] 
		public inkWidgetReference BannerButtonWidget
		{
			get => GetProperty(ref _bannerButtonWidget);
			set => SetProperty(ref _bannerButtonWidget, value);
		}

		[Ordinal(10)] 
		[RED("bannerData")] 
		public SBannerWidgetPackage BannerData
		{
			get => GetProperty(ref _bannerData);
			set => SetProperty(ref _bannerData, value);
		}

		[Ordinal(11)] 
		[RED("lastPlayedVideo")] 
		public redResourceReferenceScriptToken LastPlayedVideo
		{
			get => GetProperty(ref _lastPlayedVideo);
			set => SetProperty(ref _lastPlayedVideo, value);
		}

		public ComputerBannerWidgetController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
