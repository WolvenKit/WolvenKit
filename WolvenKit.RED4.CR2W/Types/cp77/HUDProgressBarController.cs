using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HUDProgressBarController : gameuiHUDGameController
	{
		private inkWidgetReference _bar;
		private inkTextWidgetReference _header;
		private inkTextWidgetReference _percent;
		private inkTextWidgetReference _completed;
		private inkTextWidgetReference _failed;
		private wCHandle<inkWidget> _rootWidget;
		private CHandle<gameIBlackboard> _progressBarBB;
		private CHandle<UI_HUDProgressBarDef> _progressBarDef;
		private CUInt32 _activeBBID;
		private CUInt32 _headerBBID;
		private CUInt32 _progressBBID;
		private CHandle<inkanimProxy> _outroAnimation;
		private CHandle<inkanimProxy> _loopAnimation;
		private CHandle<inkanimProxy> _introAnimation;
		private CBool _introWasPlayed;
		private CFloat _valueSaved;

		[Ordinal(9)] 
		[RED("bar")] 
		public inkWidgetReference Bar
		{
			get
			{
				if (_bar == null)
				{
					_bar = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "bar", cr2w, this);
				}
				return _bar;
			}
			set
			{
				if (_bar == value)
				{
					return;
				}
				_bar = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("header")] 
		public inkTextWidgetReference Header
		{
			get
			{
				if (_header == null)
				{
					_header = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "header", cr2w, this);
				}
				return _header;
			}
			set
			{
				if (_header == value)
				{
					return;
				}
				_header = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("percent")] 
		public inkTextWidgetReference Percent
		{
			get
			{
				if (_percent == null)
				{
					_percent = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "percent", cr2w, this);
				}
				return _percent;
			}
			set
			{
				if (_percent == value)
				{
					return;
				}
				_percent = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("completed")] 
		public inkTextWidgetReference Completed
		{
			get
			{
				if (_completed == null)
				{
					_completed = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "completed", cr2w, this);
				}
				return _completed;
			}
			set
			{
				if (_completed == value)
				{
					return;
				}
				_completed = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("failed")] 
		public inkTextWidgetReference Failed
		{
			get
			{
				if (_failed == null)
				{
					_failed = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "failed", cr2w, this);
				}
				return _failed;
			}
			set
			{
				if (_failed == value)
				{
					return;
				}
				_failed = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "rootWidget", cr2w, this);
				}
				return _rootWidget;
			}
			set
			{
				if (_rootWidget == value)
				{
					return;
				}
				_rootWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("progressBarBB")] 
		public CHandle<gameIBlackboard> ProgressBarBB
		{
			get
			{
				if (_progressBarBB == null)
				{
					_progressBarBB = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "progressBarBB", cr2w, this);
				}
				return _progressBarBB;
			}
			set
			{
				if (_progressBarBB == value)
				{
					return;
				}
				_progressBarBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("progressBarDef")] 
		public CHandle<UI_HUDProgressBarDef> ProgressBarDef
		{
			get
			{
				if (_progressBarDef == null)
				{
					_progressBarDef = (CHandle<UI_HUDProgressBarDef>) CR2WTypeManager.Create("handle:UI_HUDProgressBarDef", "progressBarDef", cr2w, this);
				}
				return _progressBarDef;
			}
			set
			{
				if (_progressBarDef == value)
				{
					return;
				}
				_progressBarDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("activeBBID")] 
		public CUInt32 ActiveBBID
		{
			get
			{
				if (_activeBBID == null)
				{
					_activeBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "activeBBID", cr2w, this);
				}
				return _activeBBID;
			}
			set
			{
				if (_activeBBID == value)
				{
					return;
				}
				_activeBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("headerBBID")] 
		public CUInt32 HeaderBBID
		{
			get
			{
				if (_headerBBID == null)
				{
					_headerBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "headerBBID", cr2w, this);
				}
				return _headerBBID;
			}
			set
			{
				if (_headerBBID == value)
				{
					return;
				}
				_headerBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("progressBBID")] 
		public CUInt32 ProgressBBID
		{
			get
			{
				if (_progressBBID == null)
				{
					_progressBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "progressBBID", cr2w, this);
				}
				return _progressBBID;
			}
			set
			{
				if (_progressBBID == value)
				{
					return;
				}
				_progressBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("OutroAnimation")] 
		public CHandle<inkanimProxy> OutroAnimation
		{
			get
			{
				if (_outroAnimation == null)
				{
					_outroAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "OutroAnimation", cr2w, this);
				}
				return _outroAnimation;
			}
			set
			{
				if (_outroAnimation == value)
				{
					return;
				}
				_outroAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("LoopAnimation")] 
		public CHandle<inkanimProxy> LoopAnimation
		{
			get
			{
				if (_loopAnimation == null)
				{
					_loopAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "LoopAnimation", cr2w, this);
				}
				return _loopAnimation;
			}
			set
			{
				if (_loopAnimation == value)
				{
					return;
				}
				_loopAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("IntroAnimation")] 
		public CHandle<inkanimProxy> IntroAnimation
		{
			get
			{
				if (_introAnimation == null)
				{
					_introAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "IntroAnimation", cr2w, this);
				}
				return _introAnimation;
			}
			set
			{
				if (_introAnimation == value)
				{
					return;
				}
				_introAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("IntroWasPlayed")] 
		public CBool IntroWasPlayed
		{
			get
			{
				if (_introWasPlayed == null)
				{
					_introWasPlayed = (CBool) CR2WTypeManager.Create("Bool", "IntroWasPlayed", cr2w, this);
				}
				return _introWasPlayed;
			}
			set
			{
				if (_introWasPlayed == value)
				{
					return;
				}
				_introWasPlayed = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("valueSaved")] 
		public CFloat ValueSaved
		{
			get
			{
				if (_valueSaved == null)
				{
					_valueSaved = (CFloat) CR2WTypeManager.Create("Float", "valueSaved", cr2w, this);
				}
				return _valueSaved;
			}
			set
			{
				if (_valueSaved == value)
				{
					return;
				}
				_valueSaved = value;
				PropertySet(this);
			}
		}

		public HUDProgressBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
