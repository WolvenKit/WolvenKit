using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BraindanceClueLogicController : inkWidgetLogicController
	{
		private inkWidgetReference _bg;
		private CName _timelineActiveAnimationName;
		private CName _timelineDisabledAnimationName;
		private CHandle<inkanimProxy> _timelineActiveAnimation;
		private CHandle<inkanimProxy> _timelineDisabledAnimation;
		private CEnum<ClueState> _state;
		private BraindanceClueData _data;
		private CBool _isInLayer;
		private CBool _isInTimeWindow;

		[Ordinal(1)] 
		[RED("bg")] 
		public inkWidgetReference Bg
		{
			get => GetProperty(ref _bg);
			set => SetProperty(ref _bg, value);
		}

		[Ordinal(2)] 
		[RED("timelineActiveAnimationName")] 
		public CName TimelineActiveAnimationName
		{
			get => GetProperty(ref _timelineActiveAnimationName);
			set => SetProperty(ref _timelineActiveAnimationName, value);
		}

		[Ordinal(3)] 
		[RED("timelineDisabledAnimationName")] 
		public CName TimelineDisabledAnimationName
		{
			get => GetProperty(ref _timelineDisabledAnimationName);
			set => SetProperty(ref _timelineDisabledAnimationName, value);
		}

		[Ordinal(4)] 
		[RED("timelineActiveAnimation")] 
		public CHandle<inkanimProxy> TimelineActiveAnimation
		{
			get => GetProperty(ref _timelineActiveAnimation);
			set => SetProperty(ref _timelineActiveAnimation, value);
		}

		[Ordinal(5)] 
		[RED("timelineDisabledAnimation")] 
		public CHandle<inkanimProxy> TimelineDisabledAnimation
		{
			get => GetProperty(ref _timelineDisabledAnimation);
			set => SetProperty(ref _timelineDisabledAnimation, value);
		}

		[Ordinal(6)] 
		[RED("state")] 
		public CEnum<ClueState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(7)] 
		[RED("data")] 
		public BraindanceClueData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(8)] 
		[RED("isInLayer")] 
		public CBool IsInLayer
		{
			get => GetProperty(ref _isInLayer);
			set => SetProperty(ref _isInLayer, value);
		}

		[Ordinal(9)] 
		[RED("isInTimeWindow")] 
		public CBool IsInTimeWindow
		{
			get => GetProperty(ref _isInTimeWindow);
			set => SetProperty(ref _isInTimeWindow, value);
		}
	}
}
