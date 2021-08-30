using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TimeMenuGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _selectTimeText;
		private inkWidgetReference _selectorRef;
		private inkTextWidgetReference _currentTime;
		private inkWidgetReference _applyBtn;
		private inkWidgetReference _backBtn;
		private inkTextWidgetReference _combatWarning;
		private CHandle<TimeSkipPopupData> _data;
		private ScriptGameInstance _gameInstance;
		private CBool _inputEnabled;
		private CBool _timeChanged;
		private CWeakHandle<inkSelectorController> _selectorCtrl;
		private CHandle<gameTimeSystem> _timeSystem;
		private CInt32 _hoursToSkip;
		private CWeakHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private CHandle<textTextParameterSet> _currentTimeTextParams;
		private CHandle<inkanimProxy> _animProxy;
		private CUInt32 _playerSpawnedCallbackID;

		[Ordinal(2)] 
		[RED("selectTimeText")] 
		public inkWidgetReference SelectTimeText
		{
			get => GetProperty(ref _selectTimeText);
			set => SetProperty(ref _selectTimeText, value);
		}

		[Ordinal(3)] 
		[RED("selectorRef")] 
		public inkWidgetReference SelectorRef
		{
			get => GetProperty(ref _selectorRef);
			set => SetProperty(ref _selectorRef, value);
		}

		[Ordinal(4)] 
		[RED("currentTime")] 
		public inkTextWidgetReference CurrentTime
		{
			get => GetProperty(ref _currentTime);
			set => SetProperty(ref _currentTime, value);
		}

		[Ordinal(5)] 
		[RED("applyBtn")] 
		public inkWidgetReference ApplyBtn
		{
			get => GetProperty(ref _applyBtn);
			set => SetProperty(ref _applyBtn, value);
		}

		[Ordinal(6)] 
		[RED("backBtn")] 
		public inkWidgetReference BackBtn
		{
			get => GetProperty(ref _backBtn);
			set => SetProperty(ref _backBtn, value);
		}

		[Ordinal(7)] 
		[RED("combatWarning")] 
		public inkTextWidgetReference CombatWarning
		{
			get => GetProperty(ref _combatWarning);
			set => SetProperty(ref _combatWarning, value);
		}

		[Ordinal(8)] 
		[RED("data")] 
		public CHandle<TimeSkipPopupData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(9)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(10)] 
		[RED("inputEnabled")] 
		public CBool InputEnabled
		{
			get => GetProperty(ref _inputEnabled);
			set => SetProperty(ref _inputEnabled, value);
		}

		[Ordinal(11)] 
		[RED("timeChanged")] 
		public CBool TimeChanged
		{
			get => GetProperty(ref _timeChanged);
			set => SetProperty(ref _timeChanged, value);
		}

		[Ordinal(12)] 
		[RED("selectorCtrl")] 
		public CWeakHandle<inkSelectorController> SelectorCtrl
		{
			get => GetProperty(ref _selectorCtrl);
			set => SetProperty(ref _selectorCtrl, value);
		}

		[Ordinal(13)] 
		[RED("timeSystem")] 
		public CHandle<gameTimeSystem> TimeSystem
		{
			get => GetProperty(ref _timeSystem);
			set => SetProperty(ref _timeSystem, value);
		}

		[Ordinal(14)] 
		[RED("hoursToSkip")] 
		public CInt32 HoursToSkip
		{
			get => GetProperty(ref _hoursToSkip);
			set => SetProperty(ref _hoursToSkip, value);
		}

		[Ordinal(15)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(16)] 
		[RED("currentTimeTextParams")] 
		public CHandle<textTextParameterSet> CurrentTimeTextParams
		{
			get => GetProperty(ref _currentTimeTextParams);
			set => SetProperty(ref _currentTimeTextParams, value);
		}

		[Ordinal(17)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(18)] 
		[RED("playerSpawnedCallbackID")] 
		public CUInt32 PlayerSpawnedCallbackID
		{
			get => GetProperty(ref _playerSpawnedCallbackID);
			set => SetProperty(ref _playerSpawnedCallbackID, value);
		}

		public TimeMenuGameController()
		{
			_inputEnabled = true;
		}
	}
}
