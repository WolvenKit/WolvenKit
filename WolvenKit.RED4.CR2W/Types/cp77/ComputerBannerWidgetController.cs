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
			get
			{
				if (_titleWidget == null)
				{
					_titleWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "titleWidget", cr2w, this);
				}
				return _titleWidget;
			}
			set
			{
				if (_titleWidget == value)
				{
					return;
				}
				_titleWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("textContentWidget")] 
		public inkTextWidgetReference TextContentWidget
		{
			get
			{
				if (_textContentWidget == null)
				{
					_textContentWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "textContentWidget", cr2w, this);
				}
				return _textContentWidget;
			}
			set
			{
				if (_textContentWidget == value)
				{
					return;
				}
				_textContentWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("videoContentWidget")] 
		public inkVideoWidgetReference VideoContentWidget
		{
			get
			{
				if (_videoContentWidget == null)
				{
					_videoContentWidget = (inkVideoWidgetReference) CR2WTypeManager.Create("inkVideoWidgetReference", "videoContentWidget", cr2w, this);
				}
				return _videoContentWidget;
			}
			set
			{
				if (_videoContentWidget == value)
				{
					return;
				}
				_videoContentWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("imageContentWidget")] 
		public inkImageWidgetReference ImageContentWidget
		{
			get
			{
				if (_imageContentWidget == null)
				{
					_imageContentWidget = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "imageContentWidget", cr2w, this);
				}
				return _imageContentWidget;
			}
			set
			{
				if (_imageContentWidget == value)
				{
					return;
				}
				_imageContentWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("bannerButtonWidget")] 
		public inkWidgetReference BannerButtonWidget
		{
			get
			{
				if (_bannerButtonWidget == null)
				{
					_bannerButtonWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "bannerButtonWidget", cr2w, this);
				}
				return _bannerButtonWidget;
			}
			set
			{
				if (_bannerButtonWidget == value)
				{
					return;
				}
				_bannerButtonWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("bannerData")] 
		public SBannerWidgetPackage BannerData
		{
			get
			{
				if (_bannerData == null)
				{
					_bannerData = (SBannerWidgetPackage) CR2WTypeManager.Create("SBannerWidgetPackage", "bannerData", cr2w, this);
				}
				return _bannerData;
			}
			set
			{
				if (_bannerData == value)
				{
					return;
				}
				_bannerData = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("lastPlayedVideo")] 
		public redResourceReferenceScriptToken LastPlayedVideo
		{
			get
			{
				if (_lastPlayedVideo == null)
				{
					_lastPlayedVideo = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "lastPlayedVideo", cr2w, this);
				}
				return _lastPlayedVideo;
			}
			set
			{
				if (_lastPlayedVideo == value)
				{
					return;
				}
				_lastPlayedVideo = value;
				PropertySet(this);
			}
		}

		public ComputerBannerWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
