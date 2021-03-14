using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HUDSignalProgressBarController : gameuiHUDGameController
	{
		private inkWidgetReference _bar;
		private inkWidgetReference _completed;
		private inkWidgetReference _signalLost;
		private inkTextWidgetReference _percent;
		private CArray<inkWidgetReference> _signalBars;
		private wCHandle<inkWidget> _rootWidget;
		private CHandle<gameIBlackboard> _progressBarBB;
		private CHandle<UI_HUDSignalProgressBarDef> _progressBarDef;
		private CUInt32 _stateBBID;
		private CUInt32 _progressBBID;
		private CUInt32 _signalStrengthBBID;
		private HUDProgressBarData _data;
		private CHandle<inkanimProxy> _outroAnimation;
		private CHandle<inkanimProxy> _signalLostAnimation;
		private CHandle<inkanimProxy> _introAnimation;
		private CHandle<inkanimDefinition> _alpha_fadein;
		private CHandle<inkanimProxy> _animProxy;
		private inkanimPlaybackOptions _animOptions;
		private CHandle<inkanimTransparencyInterpolator> _alphaInterpolator;
		private CFloat _tick;

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
		[RED("completed")] 
		public inkWidgetReference Completed
		{
			get
			{
				if (_completed == null)
				{
					_completed = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "completed", cr2w, this);
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

		[Ordinal(11)] 
		[RED("signalLost")] 
		public inkWidgetReference SignalLost
		{
			get
			{
				if (_signalLost == null)
				{
					_signalLost = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "signalLost", cr2w, this);
				}
				return _signalLost;
			}
			set
			{
				if (_signalLost == value)
				{
					return;
				}
				_signalLost = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
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

		[Ordinal(13)] 
		[RED("signalBars")] 
		public CArray<inkWidgetReference> SignalBars
		{
			get
			{
				if (_signalBars == null)
				{
					_signalBars = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "signalBars", cr2w, this);
				}
				return _signalBars;
			}
			set
			{
				if (_signalBars == value)
				{
					return;
				}
				_signalBars = value;
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
		public CHandle<UI_HUDSignalProgressBarDef> ProgressBarDef
		{
			get
			{
				if (_progressBarDef == null)
				{
					_progressBarDef = (CHandle<UI_HUDSignalProgressBarDef>) CR2WTypeManager.Create("handle:UI_HUDSignalProgressBarDef", "progressBarDef", cr2w, this);
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
		[RED("stateBBID")] 
		public CUInt32 StateBBID
		{
			get
			{
				if (_stateBBID == null)
				{
					_stateBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "stateBBID", cr2w, this);
				}
				return _stateBBID;
			}
			set
			{
				if (_stateBBID == value)
				{
					return;
				}
				_stateBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
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

		[Ordinal(19)] 
		[RED("signalStrengthBBID")] 
		public CUInt32 SignalStrengthBBID
		{
			get
			{
				if (_signalStrengthBBID == null)
				{
					_signalStrengthBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "signalStrengthBBID", cr2w, this);
				}
				return _signalStrengthBBID;
			}
			set
			{
				if (_signalStrengthBBID == value)
				{
					return;
				}
				_signalStrengthBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("data")] 
		public HUDProgressBarData Data
		{
			get
			{
				if (_data == null)
				{
					_data = (HUDProgressBarData) CR2WTypeManager.Create("HUDProgressBarData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
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

		[Ordinal(22)] 
		[RED("SignalLostAnimation")] 
		public CHandle<inkanimProxy> SignalLostAnimation
		{
			get
			{
				if (_signalLostAnimation == null)
				{
					_signalLostAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "SignalLostAnimation", cr2w, this);
				}
				return _signalLostAnimation;
			}
			set
			{
				if (_signalLostAnimation == value)
				{
					return;
				}
				_signalLostAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
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

		[Ordinal(24)] 
		[RED("alpha_fadein")] 
		public CHandle<inkanimDefinition> Alpha_fadein
		{
			get
			{
				if (_alpha_fadein == null)
				{
					_alpha_fadein = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "alpha_fadein", cr2w, this);
				}
				return _alpha_fadein;
			}
			set
			{
				if (_alpha_fadein == value)
				{
					return;
				}
				_alpha_fadein = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("AnimProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "AnimProxy", cr2w, this);
				}
				return _animProxy;
			}
			set
			{
				if (_animProxy == value)
				{
					return;
				}
				_animProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("AnimOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get
			{
				if (_animOptions == null)
				{
					_animOptions = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "AnimOptions", cr2w, this);
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

		[Ordinal(27)] 
		[RED("alphaInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> AlphaInterpolator
		{
			get
			{
				if (_alphaInterpolator == null)
				{
					_alphaInterpolator = (CHandle<inkanimTransparencyInterpolator>) CR2WTypeManager.Create("handle:inkanimTransparencyInterpolator", "alphaInterpolator", cr2w, this);
				}
				return _alphaInterpolator;
			}
			set
			{
				if (_alphaInterpolator == value)
				{
					return;
				}
				_alphaInterpolator = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("tick")] 
		public CFloat Tick
		{
			get
			{
				if (_tick == null)
				{
					_tick = (CFloat) CR2WTypeManager.Create("Float", "tick", cr2w, this);
				}
				return _tick;
			}
			set
			{
				if (_tick == value)
				{
					return;
				}
				_tick = value;
				PropertySet(this);
			}
		}

		public HUDSignalProgressBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
