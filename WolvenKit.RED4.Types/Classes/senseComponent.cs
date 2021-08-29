using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class senseComponent : entIPlacedComponent
	{
		private CBool _enableBeingDetectable;
		private CHandle<senseVisibleObject> _visibleObject;
		private CHandle<senseSensorObject> _sensorObject;
		private CBool _isEnabled;
		private CHandle<redCallbackObject> _highLevelCb;
		private CHandle<redCallbackObject> _reactionCb;
		private CEnum<gamedataNPCHighLevelState> _highLevelState;
		private TweakDBID _mainPreset;
		private TweakDBID _secondaryPreset;
		private CWeakHandle<gameIBlackboard> _puppetBlackboard;
		private CHandle<redCallbackObject> _playerTakedownStateCallbackID;
		private CHandle<redCallbackObject> _playerUpperBodyStateCallbackID;
		private CHandle<redCallbackObject> _playerCarryingStateCallbackID;
		private CWeakHandle<PlayerPuppet> _playerInPerception;

		[Ordinal(5)] 
		[RED("enableBeingDetectable")] 
		public CBool EnableBeingDetectable
		{
			get => GetProperty(ref _enableBeingDetectable);
			set => SetProperty(ref _enableBeingDetectable, value);
		}

		[Ordinal(6)] 
		[RED("visibleObject")] 
		public CHandle<senseVisibleObject> VisibleObject
		{
			get => GetProperty(ref _visibleObject);
			set => SetProperty(ref _visibleObject, value);
		}

		[Ordinal(7)] 
		[RED("sensorObject")] 
		public CHandle<senseSensorObject> SensorObject
		{
			get => GetProperty(ref _sensorObject);
			set => SetProperty(ref _sensorObject, value);
		}

		[Ordinal(8)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(9)] 
		[RED("highLevelCb")] 
		public CHandle<redCallbackObject> HighLevelCb
		{
			get => GetProperty(ref _highLevelCb);
			set => SetProperty(ref _highLevelCb, value);
		}

		[Ordinal(10)] 
		[RED("reactionCb")] 
		public CHandle<redCallbackObject> ReactionCb
		{
			get => GetProperty(ref _reactionCb);
			set => SetProperty(ref _reactionCb, value);
		}

		[Ordinal(11)] 
		[RED("highLevelState")] 
		public CEnum<gamedataNPCHighLevelState> HighLevelState
		{
			get => GetProperty(ref _highLevelState);
			set => SetProperty(ref _highLevelState, value);
		}

		[Ordinal(12)] 
		[RED("mainPreset")] 
		public TweakDBID MainPreset
		{
			get => GetProperty(ref _mainPreset);
			set => SetProperty(ref _mainPreset, value);
		}

		[Ordinal(13)] 
		[RED("secondaryPreset")] 
		public TweakDBID SecondaryPreset
		{
			get => GetProperty(ref _secondaryPreset);
			set => SetProperty(ref _secondaryPreset, value);
		}

		[Ordinal(14)] 
		[RED("puppetBlackboard")] 
		public CWeakHandle<gameIBlackboard> PuppetBlackboard
		{
			get => GetProperty(ref _puppetBlackboard);
			set => SetProperty(ref _puppetBlackboard, value);
		}

		[Ordinal(15)] 
		[RED("playerTakedownStateCallbackID")] 
		public CHandle<redCallbackObject> PlayerTakedownStateCallbackID
		{
			get => GetProperty(ref _playerTakedownStateCallbackID);
			set => SetProperty(ref _playerTakedownStateCallbackID, value);
		}

		[Ordinal(16)] 
		[RED("playerUpperBodyStateCallbackID")] 
		public CHandle<redCallbackObject> PlayerUpperBodyStateCallbackID
		{
			get => GetProperty(ref _playerUpperBodyStateCallbackID);
			set => SetProperty(ref _playerUpperBodyStateCallbackID, value);
		}

		[Ordinal(17)] 
		[RED("playerCarryingStateCallbackID")] 
		public CHandle<redCallbackObject> PlayerCarryingStateCallbackID
		{
			get => GetProperty(ref _playerCarryingStateCallbackID);
			set => SetProperty(ref _playerCarryingStateCallbackID, value);
		}

		[Ordinal(18)] 
		[RED("playerInPerception")] 
		public CWeakHandle<PlayerPuppet> PlayerInPerception
		{
			get => GetProperty(ref _playerInPerception);
			set => SetProperty(ref _playerInPerception, value);
		}
	}
}
