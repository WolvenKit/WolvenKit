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
			get => GetProperty(ref _bar);
			set => SetProperty(ref _bar, value);
		}

		[Ordinal(2)] 
		[RED("timerValue")] 
		public inkTextWidgetReference TimerValue
		{
			get => GetProperty(ref _timerValue);
			set => SetProperty(ref _timerValue, value);
		}

		[Ordinal(3)] 
		[RED("progressAnimDef")] 
		public CHandle<inkanimDefinition> ProgressAnimDef
		{
			get => GetProperty(ref _progressAnimDef);
			set => SetProperty(ref _progressAnimDef, value);
		}

		[Ordinal(4)] 
		[RED("timerAnimDef")] 
		public CHandle<inkanimDefinition> TimerAnimDef
		{
			get => GetProperty(ref _timerAnimDef);
			set => SetProperty(ref _timerAnimDef, value);
		}

		[Ordinal(5)] 
		[RED("ProgressAnimInterpolator")] 
		public CHandle<inkanimScaleInterpolator> ProgressAnimInterpolator
		{
			get => GetProperty(ref _progressAnimInterpolator);
			set => SetProperty(ref _progressAnimInterpolator, value);
		}

		[Ordinal(6)] 
		[RED("timerAnimInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> TimerAnimInterpolator
		{
			get => GetProperty(ref _timerAnimInterpolator);
			set => SetProperty(ref _timerAnimInterpolator, value);
		}

		[Ordinal(7)] 
		[RED("timerAnimProxy")] 
		public CHandle<inkanimProxy> TimerAnimProxy
		{
			get => GetProperty(ref _timerAnimProxy);
			set => SetProperty(ref _timerAnimProxy, value);
		}

		[Ordinal(8)] 
		[RED("timerBarAnimProxy")] 
		public CHandle<inkanimProxy> TimerBarAnimProxy
		{
			get => GetProperty(ref _timerBarAnimProxy);
			set => SetProperty(ref _timerBarAnimProxy, value);
		}

		[Ordinal(9)] 
		[RED("AnimOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get => GetProperty(ref _animOptions);
			set => SetProperty(ref _animOptions, value);
		}

		[Ordinal(10)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		public DialogChoiceTimerController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
