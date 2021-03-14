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
			get
			{
				if (_processingVideo == null)
				{
					_processingVideo = (inkVideoWidgetReference) CR2WTypeManager.Create("inkVideoWidgetReference", "ProcessingVideo", cr2w, this);
				}
				return _processingVideo;
			}
			set
			{
				if (_processingVideo == value)
				{
					return;
				}
				_processingVideo = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("PersonalAd")] 
		public inkVideoWidgetReference PersonalAd
		{
			get
			{
				if (_personalAd == null)
				{
					_personalAd = (inkVideoWidgetReference) CR2WTypeManager.Create("inkVideoWidgetReference", "PersonalAd", cr2w, this);
				}
				return _personalAd;
			}
			set
			{
				if (_personalAd == value)
				{
					return;
				}
				_personalAd = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("CommonAd")] 
		public inkVideoWidgetReference CommonAd
		{
			get
			{
				if (_commonAd == null)
				{
					_commonAd = (inkVideoWidgetReference) CR2WTypeManager.Create("inkVideoWidgetReference", "CommonAd", cr2w, this);
				}
				return _commonAd;
			}
			set
			{
				if (_commonAd == value)
				{
					return;
				}
				_commonAd = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("fadeDuration")] 
		public CFloat FadeDuration
		{
			get
			{
				if (_fadeDuration == null)
				{
					_fadeDuration = (CFloat) CR2WTypeManager.Create("Float", "fadeDuration", cr2w, this);
				}
				return _fadeDuration;
			}
			set
			{
				if (_fadeDuration == value)
				{
					return;
				}
				_fadeDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("animFade")] 
		public CHandle<inkanimDefinition> AnimFade
		{
			get
			{
				if (_animFade == null)
				{
					_animFade = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "animFade", cr2w, this);
				}
				return _animFade;
			}
			set
			{
				if (_animFade == value)
				{
					return;
				}
				_animFade = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("animOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get
			{
				if (_animOptions == null)
				{
					_animOptions = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "animOptions", cr2w, this);
				}
				return _animOptions;
			}
			set
			{
				if (_animOptions == value)
				{
					return;
				}
				_animOptions = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("showAd")] 
		public CBool ShowAd
		{
			get
			{
				if (_showAd == null)
				{
					_showAd = (CBool) CR2WTypeManager.Create("Bool", "showAd", cr2w, this);
				}
				return _showAd;
			}
			set
			{
				if (_showAd == value)
				{
					return;
				}
				_showAd = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("onShowAdListener")] 
		public CUInt32 OnShowAdListener
		{
			get
			{
				if (_onShowAdListener == null)
				{
					_onShowAdListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onShowAdListener", cr2w, this);
				}
				return _onShowAdListener;
			}
			set
			{
				if (_onShowAdListener == value)
				{
					return;
				}
				_onShowAdListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("onShowVendorListener")] 
		public CUInt32 OnShowVendorListener
		{
			get
			{
				if (_onShowVendorListener == null)
				{
					_onShowVendorListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onShowVendorListener", cr2w, this);
				}
				return _onShowVendorListener;
			}
			set
			{
				if (_onShowVendorListener == value)
				{
					return;
				}
				_onShowVendorListener = value;
				PropertySet(this);
			}
		}

		public InteractiveAdInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
