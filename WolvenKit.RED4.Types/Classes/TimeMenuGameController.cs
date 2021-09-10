using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TimeMenuGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("selectTimeText")] 
		public inkWidgetReference SelectTimeText
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("selectorRef")] 
		public inkWidgetReference SelectorRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("currentTime")] 
		public inkTextWidgetReference CurrentTime
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("applyBtn")] 
		public inkWidgetReference ApplyBtn
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("backBtn")] 
		public inkWidgetReference BackBtn
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("combatWarning")] 
		public inkTextWidgetReference CombatWarning
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("data")] 
		public CHandle<TimeSkipPopupData> Data
		{
			get => GetPropertyValue<CHandle<TimeSkipPopupData>>();
			set => SetPropertyValue<CHandle<TimeSkipPopupData>>(value);
		}

		[Ordinal(9)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(10)] 
		[RED("inputEnabled")] 
		public CBool InputEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("timeChanged")] 
		public CBool TimeChanged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("selectorCtrl")] 
		public CWeakHandle<inkSelectorController> SelectorCtrl
		{
			get => GetPropertyValue<CWeakHandle<inkSelectorController>>();
			set => SetPropertyValue<CWeakHandle<inkSelectorController>>(value);
		}

		[Ordinal(13)] 
		[RED("timeSystem")] 
		public CHandle<gameTimeSystem> TimeSystem
		{
			get => GetPropertyValue<CHandle<gameTimeSystem>>();
			set => SetPropertyValue<CHandle<gameTimeSystem>>(value);
		}

		[Ordinal(14)] 
		[RED("hoursToSkip")] 
		public CInt32 HoursToSkip
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(15)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(16)] 
		[RED("currentTimeTextParams")] 
		public CHandle<textTextParameterSet> CurrentTimeTextParams
		{
			get => GetPropertyValue<CHandle<textTextParameterSet>>();
			set => SetPropertyValue<CHandle<textTextParameterSet>>(value);
		}

		[Ordinal(17)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(18)] 
		[RED("playerSpawnedCallbackID")] 
		public CUInt32 PlayerSpawnedCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public TimeMenuGameController()
		{
			SelectTimeText = new();
			SelectorRef = new();
			CurrentTime = new();
			ApplyBtn = new();
			BackBtn = new();
			CombatWarning = new();
			GameInstance = new();
			InputEnabled = true;
		}
	}
}
