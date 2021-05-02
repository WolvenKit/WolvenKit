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
			get => GetProperty(ref _bar);
			set => SetProperty(ref _bar, value);
		}

		[Ordinal(10)] 
		[RED("completed")] 
		public inkWidgetReference Completed
		{
			get => GetProperty(ref _completed);
			set => SetProperty(ref _completed, value);
		}

		[Ordinal(11)] 
		[RED("signalLost")] 
		public inkWidgetReference SignalLost
		{
			get => GetProperty(ref _signalLost);
			set => SetProperty(ref _signalLost, value);
		}

		[Ordinal(12)] 
		[RED("percent")] 
		public inkTextWidgetReference Percent
		{
			get => GetProperty(ref _percent);
			set => SetProperty(ref _percent, value);
		}

		[Ordinal(13)] 
		[RED("signalBars")] 
		public CArray<inkWidgetReference> SignalBars
		{
			get => GetProperty(ref _signalBars);
			set => SetProperty(ref _signalBars, value);
		}

		[Ordinal(14)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(15)] 
		[RED("progressBarBB")] 
		public CHandle<gameIBlackboard> ProgressBarBB
		{
			get => GetProperty(ref _progressBarBB);
			set => SetProperty(ref _progressBarBB, value);
		}

		[Ordinal(16)] 
		[RED("progressBarDef")] 
		public CHandle<UI_HUDSignalProgressBarDef> ProgressBarDef
		{
			get => GetProperty(ref _progressBarDef);
			set => SetProperty(ref _progressBarDef, value);
		}

		[Ordinal(17)] 
		[RED("stateBBID")] 
		public CUInt32 StateBBID
		{
			get => GetProperty(ref _stateBBID);
			set => SetProperty(ref _stateBBID, value);
		}

		[Ordinal(18)] 
		[RED("progressBBID")] 
		public CUInt32 ProgressBBID
		{
			get => GetProperty(ref _progressBBID);
			set => SetProperty(ref _progressBBID, value);
		}

		[Ordinal(19)] 
		[RED("signalStrengthBBID")] 
		public CUInt32 SignalStrengthBBID
		{
			get => GetProperty(ref _signalStrengthBBID);
			set => SetProperty(ref _signalStrengthBBID, value);
		}

		[Ordinal(20)] 
		[RED("data")] 
		public HUDProgressBarData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(21)] 
		[RED("OutroAnimation")] 
		public CHandle<inkanimProxy> OutroAnimation
		{
			get => GetProperty(ref _outroAnimation);
			set => SetProperty(ref _outroAnimation, value);
		}

		[Ordinal(22)] 
		[RED("SignalLostAnimation")] 
		public CHandle<inkanimProxy> SignalLostAnimation
		{
			get => GetProperty(ref _signalLostAnimation);
			set => SetProperty(ref _signalLostAnimation, value);
		}

		[Ordinal(23)] 
		[RED("IntroAnimation")] 
		public CHandle<inkanimProxy> IntroAnimation
		{
			get => GetProperty(ref _introAnimation);
			set => SetProperty(ref _introAnimation, value);
		}

		[Ordinal(24)] 
		[RED("alpha_fadein")] 
		public CHandle<inkanimDefinition> Alpha_fadein
		{
			get => GetProperty(ref _alpha_fadein);
			set => SetProperty(ref _alpha_fadein, value);
		}

		[Ordinal(25)] 
		[RED("AnimProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(26)] 
		[RED("AnimOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get => GetProperty(ref _animOptions);
			set => SetProperty(ref _animOptions, value);
		}

		[Ordinal(27)] 
		[RED("alphaInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> AlphaInterpolator
		{
			get => GetProperty(ref _alphaInterpolator);
			set => SetProperty(ref _alphaInterpolator, value);
		}

		[Ordinal(28)] 
		[RED("tick")] 
		public CFloat Tick
		{
			get => GetProperty(ref _tick);
			set => SetProperty(ref _tick, value);
		}

		public HUDSignalProgressBarController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
