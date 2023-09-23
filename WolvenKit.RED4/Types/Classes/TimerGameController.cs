using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TimerGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("value")] 
		public inkTextWidgetReference Value
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(11)] 
		[RED("timerBB")] 
		public CWeakHandle<gameIBlackboard> TimerBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(12)] 
		[RED("timerDef")] 
		public CHandle<UIGameDataDef> TimerDef
		{
			get => GetPropertyValue<CHandle<UIGameDataDef>>();
			set => SetPropertyValue<CHandle<UIGameDataDef>>(value);
		}

		[Ordinal(13)] 
		[RED("activeBBID")] 
		public CHandle<redCallbackObject> ActiveBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(14)] 
		[RED("progressBBID")] 
		public CHandle<redCallbackObject> ProgressBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public TimerGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
