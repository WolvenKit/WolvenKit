using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCreditsController : gameuiWidgetGameController
	{
		private rRef<inkCreditsResource> _creditsResourcePS4;
		private rRef<inkCreditsResource> _creditsResourceXBOXPC;
		private CFloat _scrollingSpeed;
		private CFloat _fastforwardScrollingSpeed;
		private inkCompoundWidgetReference _sectionsContainer;
		private inkTextWidgetReference _singleTextWidget;
		private inkTextWidgetReference _speakerNameTextWidget;
		private inkCompoundWidgetReference _exitTooltipContainer;
		private CName _swapBackgroundVideoAnimName;
		private CName _singleAnimName;
		private CName _openVideoScreenAnimName;
		private CName _closeVideoScreenAnimName;
		private CName _headerLibraryID;
		private CName _boldLibraryID;
		private CName _basicLibraryID;
		private CFloat _topCreditsMargin;
		private CFloat _bottomCreditsMargin;
		private CFloat _startPosition;
		private inkCompoundWidgetReference _subtitlesContainer;
		private raRef<CResource> _subtitlesLibraryPath;
		private CBool _shouldShowRewardPrompt;
		private CBool _isInFinalBoardsMode;
		private CFloat _exitNotificationDisplayTime;

		[Ordinal(2)] 
		[RED("creditsResourcePS4")] 
		public rRef<inkCreditsResource> CreditsResourcePS4
		{
			get
			{
				if (_creditsResourcePS4 == null)
				{
					_creditsResourcePS4 = (rRef<inkCreditsResource>) CR2WTypeManager.Create("rRef:inkCreditsResource", "creditsResourcePS4", cr2w, this);
				}
				return _creditsResourcePS4;
			}
			set
			{
				if (_creditsResourcePS4 == value)
				{
					return;
				}
				_creditsResourcePS4 = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("creditsResourceXBOXPC")] 
		public rRef<inkCreditsResource> CreditsResourceXBOXPC
		{
			get
			{
				if (_creditsResourceXBOXPC == null)
				{
					_creditsResourceXBOXPC = (rRef<inkCreditsResource>) CR2WTypeManager.Create("rRef:inkCreditsResource", "creditsResourceXBOXPC", cr2w, this);
				}
				return _creditsResourceXBOXPC;
			}
			set
			{
				if (_creditsResourceXBOXPC == value)
				{
					return;
				}
				_creditsResourceXBOXPC = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("scrollingSpeed")] 
		public CFloat ScrollingSpeed
		{
			get
			{
				if (_scrollingSpeed == null)
				{
					_scrollingSpeed = (CFloat) CR2WTypeManager.Create("Float", "scrollingSpeed", cr2w, this);
				}
				return _scrollingSpeed;
			}
			set
			{
				if (_scrollingSpeed == value)
				{
					return;
				}
				_scrollingSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("fastforwardScrollingSpeed")] 
		public CFloat FastforwardScrollingSpeed
		{
			get
			{
				if (_fastforwardScrollingSpeed == null)
				{
					_fastforwardScrollingSpeed = (CFloat) CR2WTypeManager.Create("Float", "fastforwardScrollingSpeed", cr2w, this);
				}
				return _fastforwardScrollingSpeed;
			}
			set
			{
				if (_fastforwardScrollingSpeed == value)
				{
					return;
				}
				_fastforwardScrollingSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("sectionsContainer")] 
		public inkCompoundWidgetReference SectionsContainer
		{
			get
			{
				if (_sectionsContainer == null)
				{
					_sectionsContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "sectionsContainer", cr2w, this);
				}
				return _sectionsContainer;
			}
			set
			{
				if (_sectionsContainer == value)
				{
					return;
				}
				_sectionsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("singleTextWidget")] 
		public inkTextWidgetReference SingleTextWidget
		{
			get
			{
				if (_singleTextWidget == null)
				{
					_singleTextWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "singleTextWidget", cr2w, this);
				}
				return _singleTextWidget;
			}
			set
			{
				if (_singleTextWidget == value)
				{
					return;
				}
				_singleTextWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("speakerNameTextWidget")] 
		public inkTextWidgetReference SpeakerNameTextWidget
		{
			get
			{
				if (_speakerNameTextWidget == null)
				{
					_speakerNameTextWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "speakerNameTextWidget", cr2w, this);
				}
				return _speakerNameTextWidget;
			}
			set
			{
				if (_speakerNameTextWidget == value)
				{
					return;
				}
				_speakerNameTextWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("exitTooltipContainer")] 
		public inkCompoundWidgetReference ExitTooltipContainer
		{
			get
			{
				if (_exitTooltipContainer == null)
				{
					_exitTooltipContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "exitTooltipContainer", cr2w, this);
				}
				return _exitTooltipContainer;
			}
			set
			{
				if (_exitTooltipContainer == value)
				{
					return;
				}
				_exitTooltipContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("swapBackgroundVideoAnimName")] 
		public CName SwapBackgroundVideoAnimName
		{
			get
			{
				if (_swapBackgroundVideoAnimName == null)
				{
					_swapBackgroundVideoAnimName = (CName) CR2WTypeManager.Create("CName", "swapBackgroundVideoAnimName", cr2w, this);
				}
				return _swapBackgroundVideoAnimName;
			}
			set
			{
				if (_swapBackgroundVideoAnimName == value)
				{
					return;
				}
				_swapBackgroundVideoAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("singleAnimName")] 
		public CName SingleAnimName
		{
			get
			{
				if (_singleAnimName == null)
				{
					_singleAnimName = (CName) CR2WTypeManager.Create("CName", "singleAnimName", cr2w, this);
				}
				return _singleAnimName;
			}
			set
			{
				if (_singleAnimName == value)
				{
					return;
				}
				_singleAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("openVideoScreenAnimName")] 
		public CName OpenVideoScreenAnimName
		{
			get
			{
				if (_openVideoScreenAnimName == null)
				{
					_openVideoScreenAnimName = (CName) CR2WTypeManager.Create("CName", "openVideoScreenAnimName", cr2w, this);
				}
				return _openVideoScreenAnimName;
			}
			set
			{
				if (_openVideoScreenAnimName == value)
				{
					return;
				}
				_openVideoScreenAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("closeVideoScreenAnimName")] 
		public CName CloseVideoScreenAnimName
		{
			get
			{
				if (_closeVideoScreenAnimName == null)
				{
					_closeVideoScreenAnimName = (CName) CR2WTypeManager.Create("CName", "closeVideoScreenAnimName", cr2w, this);
				}
				return _closeVideoScreenAnimName;
			}
			set
			{
				if (_closeVideoScreenAnimName == value)
				{
					return;
				}
				_closeVideoScreenAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("headerLibraryID")] 
		public CName HeaderLibraryID
		{
			get
			{
				if (_headerLibraryID == null)
				{
					_headerLibraryID = (CName) CR2WTypeManager.Create("CName", "headerLibraryID", cr2w, this);
				}
				return _headerLibraryID;
			}
			set
			{
				if (_headerLibraryID == value)
				{
					return;
				}
				_headerLibraryID = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("boldLibraryID")] 
		public CName BoldLibraryID
		{
			get
			{
				if (_boldLibraryID == null)
				{
					_boldLibraryID = (CName) CR2WTypeManager.Create("CName", "boldLibraryID", cr2w, this);
				}
				return _boldLibraryID;
			}
			set
			{
				if (_boldLibraryID == value)
				{
					return;
				}
				_boldLibraryID = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("basicLibraryID")] 
		public CName BasicLibraryID
		{
			get
			{
				if (_basicLibraryID == null)
				{
					_basicLibraryID = (CName) CR2WTypeManager.Create("CName", "basicLibraryID", cr2w, this);
				}
				return _basicLibraryID;
			}
			set
			{
				if (_basicLibraryID == value)
				{
					return;
				}
				_basicLibraryID = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("topCreditsMargin")] 
		public CFloat TopCreditsMargin
		{
			get
			{
				if (_topCreditsMargin == null)
				{
					_topCreditsMargin = (CFloat) CR2WTypeManager.Create("Float", "topCreditsMargin", cr2w, this);
				}
				return _topCreditsMargin;
			}
			set
			{
				if (_topCreditsMargin == value)
				{
					return;
				}
				_topCreditsMargin = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("bottomCreditsMargin")] 
		public CFloat BottomCreditsMargin
		{
			get
			{
				if (_bottomCreditsMargin == null)
				{
					_bottomCreditsMargin = (CFloat) CR2WTypeManager.Create("Float", "bottomCreditsMargin", cr2w, this);
				}
				return _bottomCreditsMargin;
			}
			set
			{
				if (_bottomCreditsMargin == value)
				{
					return;
				}
				_bottomCreditsMargin = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("startPosition")] 
		public CFloat StartPosition
		{
			get
			{
				if (_startPosition == null)
				{
					_startPosition = (CFloat) CR2WTypeManager.Create("Float", "startPosition", cr2w, this);
				}
				return _startPosition;
			}
			set
			{
				if (_startPosition == value)
				{
					return;
				}
				_startPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("subtitlesContainer")] 
		public inkCompoundWidgetReference SubtitlesContainer
		{
			get
			{
				if (_subtitlesContainer == null)
				{
					_subtitlesContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "subtitlesContainer", cr2w, this);
				}
				return _subtitlesContainer;
			}
			set
			{
				if (_subtitlesContainer == value)
				{
					return;
				}
				_subtitlesContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("subtitlesLibraryPath")] 
		public raRef<CResource> SubtitlesLibraryPath
		{
			get
			{
				if (_subtitlesLibraryPath == null)
				{
					_subtitlesLibraryPath = (raRef<CResource>) CR2WTypeManager.Create("raRef:CResource", "subtitlesLibraryPath", cr2w, this);
				}
				return _subtitlesLibraryPath;
			}
			set
			{
				if (_subtitlesLibraryPath == value)
				{
					return;
				}
				_subtitlesLibraryPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("shouldShowRewardPrompt")] 
		public CBool ShouldShowRewardPrompt
		{
			get
			{
				if (_shouldShowRewardPrompt == null)
				{
					_shouldShowRewardPrompt = (CBool) CR2WTypeManager.Create("Bool", "shouldShowRewardPrompt", cr2w, this);
				}
				return _shouldShowRewardPrompt;
			}
			set
			{
				if (_shouldShowRewardPrompt == value)
				{
					return;
				}
				_shouldShowRewardPrompt = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("isInFinalBoardsMode")] 
		public CBool IsInFinalBoardsMode
		{
			get
			{
				if (_isInFinalBoardsMode == null)
				{
					_isInFinalBoardsMode = (CBool) CR2WTypeManager.Create("Bool", "isInFinalBoardsMode", cr2w, this);
				}
				return _isInFinalBoardsMode;
			}
			set
			{
				if (_isInFinalBoardsMode == value)
				{
					return;
				}
				_isInFinalBoardsMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("exitNotificationDisplayTime")] 
		public CFloat ExitNotificationDisplayTime
		{
			get
			{
				if (_exitNotificationDisplayTime == null)
				{
					_exitNotificationDisplayTime = (CFloat) CR2WTypeManager.Create("Float", "exitNotificationDisplayTime", cr2w, this);
				}
				return _exitNotificationDisplayTime;
			}
			set
			{
				if (_exitNotificationDisplayTime == value)
				{
					return;
				}
				_exitNotificationDisplayTime = value;
				PropertySet(this);
			}
		}

		public gameuiCreditsController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
