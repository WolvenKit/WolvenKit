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
		private wCHandle<gameIBlackboard> _progressBarBB;
		private CHandle<UI_HUDProgressBarDef> _progressBarDef;
		private CHandle<redCallbackObject> _activeBBID;
		private CHandle<redCallbackObject> _headerBBID;
		private CHandle<redCallbackObject> _progressBBID;
		private CHandle<inkanimProxy> _outroAnimation;
		private CHandle<inkanimProxy> _loopAnimation;
		private CHandle<inkanimProxy> _introAnimation;
		private CBool _introWasPlayed;
		private CFloat _valueSaved;

		[Ordinal(9)] 
		[RED("bar")] 
		public inkWidgetReference Bar
		{
			get => GetProperty(ref _bar);
			set => SetProperty(ref _bar, value);
		}

		[Ordinal(10)] 
		[RED("header")] 
		public inkTextWidgetReference Header
		{
			get => GetProperty(ref _header);
			set => SetProperty(ref _header, value);
		}

		[Ordinal(11)] 
		[RED("percent")] 
		public inkTextWidgetReference Percent
		{
			get => GetProperty(ref _percent);
			set => SetProperty(ref _percent, value);
		}

		[Ordinal(12)] 
		[RED("completed")] 
		public inkTextWidgetReference Completed
		{
			get => GetProperty(ref _completed);
			set => SetProperty(ref _completed, value);
		}

		[Ordinal(13)] 
		[RED("failed")] 
		public inkTextWidgetReference Failed
		{
			get => GetProperty(ref _failed);
			set => SetProperty(ref _failed, value);
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
		public wCHandle<gameIBlackboard> ProgressBarBB
		{
			get => GetProperty(ref _progressBarBB);
			set => SetProperty(ref _progressBarBB, value);
		}

		[Ordinal(16)] 
		[RED("progressBarDef")] 
		public CHandle<UI_HUDProgressBarDef> ProgressBarDef
		{
			get => GetProperty(ref _progressBarDef);
			set => SetProperty(ref _progressBarDef, value);
		}

		[Ordinal(17)] 
		[RED("activeBBID")] 
		public CHandle<redCallbackObject> ActiveBBID
		{
			get => GetProperty(ref _activeBBID);
			set => SetProperty(ref _activeBBID, value);
		}

		[Ordinal(18)] 
		[RED("headerBBID")] 
		public CHandle<redCallbackObject> HeaderBBID
		{
			get => GetProperty(ref _headerBBID);
			set => SetProperty(ref _headerBBID, value);
		}

		[Ordinal(19)] 
		[RED("progressBBID")] 
		public CHandle<redCallbackObject> ProgressBBID
		{
			get => GetProperty(ref _progressBBID);
			set => SetProperty(ref _progressBBID, value);
		}

		[Ordinal(20)] 
		[RED("OutroAnimation")] 
		public CHandle<inkanimProxy> OutroAnimation
		{
			get => GetProperty(ref _outroAnimation);
			set => SetProperty(ref _outroAnimation, value);
		}

		[Ordinal(21)] 
		[RED("LoopAnimation")] 
		public CHandle<inkanimProxy> LoopAnimation
		{
			get => GetProperty(ref _loopAnimation);
			set => SetProperty(ref _loopAnimation, value);
		}

		[Ordinal(22)] 
		[RED("IntroAnimation")] 
		public CHandle<inkanimProxy> IntroAnimation
		{
			get => GetProperty(ref _introAnimation);
			set => SetProperty(ref _introAnimation, value);
		}

		[Ordinal(23)] 
		[RED("IntroWasPlayed")] 
		public CBool IntroWasPlayed
		{
			get => GetProperty(ref _introWasPlayed);
			set => SetProperty(ref _introWasPlayed, value);
		}

		[Ordinal(24)] 
		[RED("valueSaved")] 
		public CFloat ValueSaved
		{
			get => GetProperty(ref _valueSaved);
			set => SetProperty(ref _valueSaved, value);
		}

		public HUDProgressBarController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
