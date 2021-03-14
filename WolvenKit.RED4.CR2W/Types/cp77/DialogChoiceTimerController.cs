using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DialogChoiceTimerController : inkWidgetLogicController
	{
		private inkWidgetReference _bar;
		private inkTextWidgetReference _timerValue;
		private CHandle<inkanimDefinition> _progressAnimDef;
		private CHandle<inkanimDefinition> _timerAnimDef;
		private CHandle<inkanimScaleInterpolator> _progressAnimInterpolator;
		private CHandle<inkanimTransparencyInterpolator> _timerAnimInterpolator;
		private CHandle<inkanimProxy> _timerAnimProxy;
		private CHandle<inkanimProxy> _timerBarAnimProxy;
		private inkanimPlaybackOptions _animOptions;
		private CFloat _time;

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("timerValue")] 
		public inkTextWidgetReference TimerValue
		{
			get
			{
				if (_timerValue == null)
				{
					_timerValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "timerValue", cr2w, this);
				}
				return _timerValue;
			}
			set
			{
				if (_timerValue == value)
				{
					return;
				}
				_timerValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("progressAnimDef")] 
		public CHandle<inkanimDefinition> ProgressAnimDef
		{
			get
			{
				if (_progressAnimDef == null)
				{
					_progressAnimDef = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "progressAnimDef", cr2w, this);
				}
				return _progressAnimDef;
			}
			set
			{
				if (_progressAnimDef == value)
				{
					return;
				}
				_progressAnimDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("timerAnimDef")] 
		public CHandle<inkanimDefinition> TimerAnimDef
		{
			get
			{
				if (_timerAnimDef == null)
				{
					_timerAnimDef = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "timerAnimDef", cr2w, this);
				}
				return _timerAnimDef;
			}
			set
			{
				if (_timerAnimDef == value)
				{
					return;
				}
				_timerAnimDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ProgressAnimInterpolator")] 
		public CHandle<inkanimScaleInterpolator> ProgressAnimInterpolator
		{
			get
			{
				if (_progressAnimInterpolator == null)
				{
					_progressAnimInterpolator = (CHandle<inkanimScaleInterpolator>) CR2WTypeManager.Create("handle:inkanimScaleInterpolator", "ProgressAnimInterpolator", cr2w, this);
				}
				return _progressAnimInterpolator;
			}
			set
			{
				if (_progressAnimInterpolator == value)
				{
					return;
				}
				_progressAnimInterpolator = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("timerAnimInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> TimerAnimInterpolator
		{
			get
			{
				if (_timerAnimInterpolator == null)
				{
					_timerAnimInterpolator = (CHandle<inkanimTransparencyInterpolator>) CR2WTypeManager.Create("handle:inkanimTransparencyInterpolator", "timerAnimInterpolator", cr2w, this);
				}
				return _timerAnimInterpolator;
			}
			set
			{
				if (_timerAnimInterpolator == value)
				{
					return;
				}
				_timerAnimInterpolator = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("timerAnimProxy")] 
		public CHandle<inkanimProxy> TimerAnimProxy
		{
			get
			{
				if (_timerAnimProxy == null)
				{
					_timerAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "timerAnimProxy", cr2w, this);
				}
				return _timerAnimProxy;
			}
			set
			{
				if (_timerAnimProxy == value)
				{
					return;
				}
				_timerAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("timerBarAnimProxy")] 
		public CHandle<inkanimProxy> TimerBarAnimProxy
		{
			get
			{
				if (_timerBarAnimProxy == null)
				{
					_timerBarAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "timerBarAnimProxy", cr2w, this);
				}
				return _timerBarAnimProxy;
			}
			set
			{
				if (_timerBarAnimProxy == value)
				{
					return;
				}
				_timerBarAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
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

		[Ordinal(10)] 
		[RED("time")] 
		public CFloat Time
		{
			get
			{
				if (_time == null)
				{
					_time = (CFloat) CR2WTypeManager.Create("Float", "time", cr2w, this);
				}
				return _time;
			}
			set
			{
				if (_time == value)
				{
					return;
				}
				_time = value;
				PropertySet(this);
			}
		}

		public DialogChoiceTimerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
