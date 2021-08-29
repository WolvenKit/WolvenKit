using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TimerGameController : gameuiHUDGameController
	{
		private inkTextWidgetReference _value;
		private CWeakHandle<inkWidget> _rootWidget;
		private CWeakHandle<gameIBlackboard> _timerBB;
		private CHandle<UIGameDataDef> _timerDef;
		private CHandle<redCallbackObject> _activeBBID;
		private CHandle<redCallbackObject> _progressBBID;

		[Ordinal(9)] 
		[RED("value")] 
		public inkTextWidgetReference Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(10)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(11)] 
		[RED("timerBB")] 
		public CWeakHandle<gameIBlackboard> TimerBB
		{
			get => GetProperty(ref _timerBB);
			set => SetProperty(ref _timerBB, value);
		}

		[Ordinal(12)] 
		[RED("timerDef")] 
		public CHandle<UIGameDataDef> TimerDef
		{
			get => GetProperty(ref _timerDef);
			set => SetProperty(ref _timerDef, value);
		}

		[Ordinal(13)] 
		[RED("activeBBID")] 
		public CHandle<redCallbackObject> ActiveBBID
		{
			get => GetProperty(ref _activeBBID);
			set => SetProperty(ref _activeBBID, value);
		}

		[Ordinal(14)] 
		[RED("progressBBID")] 
		public CHandle<redCallbackObject> ProgressBBID
		{
			get => GetProperty(ref _progressBBID);
			set => SetProperty(ref _progressBBID, value);
		}
	}
}
