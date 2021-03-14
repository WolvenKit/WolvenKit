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

		[Ordinal(25)] 
		[RED("videoContainer")] 
		public inkCompoundWidgetReference VideoContainer
		{
			get
			{
				if (_videoContainer == null)
				{
					_videoContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "videoContainer", cr2w, this);
				}
				return _videoContainer;
			}
			set
			{
				if (_videoContainer == value)
				{
					return;
				}
				_videoContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("sceneTexture")] 
		public inkImageWidgetReference SceneTexture
		{
			get
			{
				if (_sceneTexture == null)
				{
					_sceneTexture = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "sceneTexture", cr2w, this);
				}
				return _sceneTexture;
			}
			set
			{
				if (_sceneTexture == value)
				{
					return;
				}
				_sceneTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("backgroundVideo")] 
		public inkVideoWidgetReference BackgroundVideo
		{
			get
			{
				if (_backgroundVideo == null)
				{
					_backgroundVideo = (inkVideoWidgetReference) CR2WTypeManager.Create("inkVideoWidgetReference", "backgroundVideo", cr2w, this);
				}
				return _backgroundVideo;
			}
			set
			{
				if (_backgroundVideo == value)
				{
					return;
				}
				_backgroundVideo = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("binkVideo")] 
		public inkVideoWidgetReference BinkVideo
		{
			get
			{
				if (_binkVideo == null)
				{
					_binkVideo = (inkVideoWidgetReference) CR2WTypeManager.Create("inkVideoWidgetReference", "binkVideo", cr2w, this);
				}
				return _binkVideo;
			}
			set
			{
				if (_binkVideo == value)
				{
					return;
				}
				_binkVideo = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("binkVideos")] 
		public CArray<gameuiBinkResource> BinkVideos
		{
			get
			{
				if (_binkVideos == null)
				{
					_binkVideos = (CArray<gameuiBinkResource>) CR2WTypeManager.Create("array:gameuiBinkResource", "binkVideos", cr2w, this);
				}
				return _binkVideos;
			}
			set
			{
				if (_binkVideos == value)
				{
					return;
				}
				_binkVideos = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("currentBinkVideo")] 
		public CInt32 CurrentBinkVideo
		{
			get
			{
				if (_currentBinkVideo == null)
				{
					_currentBinkVideo = (CInt32) CR2WTypeManager.Create("Int32", "currentBinkVideo", cr2w, this);
				}
				return _currentBinkVideo;
			}
			set
			{
				if (_currentBinkVideo == value)
				{
					return;
				}
				_currentBinkVideo = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("videoSummary")] 
		public inkVideoWidgetSummary VideoSummary
		{
			get
			{
				if (_videoSummary == null)
				{
					_videoSummary = (inkVideoWidgetSummary) CR2WTypeManager.Create("inkVideoWidgetSummary", "videoSummary", cr2w, this);
				}
				return _videoSummary;
			}
			set
			{
				if (_videoSummary == value)
				{
					return;
				}
				_videoSummary = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("isDataSet")] 
		public CBool IsDataSet
		{
			get
			{
				if (_isDataSet == null)
				{
					_isDataSet = (CBool) CR2WTypeManager.Create("Bool", "isDataSet", cr2w, this);
				}
				return _isDataSet;
			}
			set
			{
				if (_isDataSet == value)
				{
					return;
				}
				_isDataSet = value;
				PropertySet(this);
			}
		}

		public CreditsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
