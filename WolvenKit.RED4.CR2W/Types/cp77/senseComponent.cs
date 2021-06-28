using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseComponent : entIPlacedComponent
	{
		private CBool _enableBeingDetectable;
		private CHandle<senseVisibleObject> _visibleObject;
		private CHandle<senseSensorObject> _sensorObject;
		private CBool _isEnabled;
		private CUInt32 _highLevelCb;
		private CUInt32 _reactionCb;
		private CEnum<gamedataNPCHighLevelState> _highLevelState;
		private TweakDBID _mainPreset;
		private TweakDBID _secondaryPreset;
		private CHandle<gameIBlackboard> _puppetBlackboard;
		private CUInt32 _playerTakedownStateCallbackID;
		private CUInt32 _playerUpperBodyStateCallbackID;
		private CUInt32 _playerCarryingStateCallbackID;
		private wCHandle<PlayerPuppet> _playerInPerception;

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
		public CUInt32 HighLevelCb
		{
			get => GetProperty(ref _highLevelCb);
			set => SetProperty(ref _highLevelCb, value);
		}

		[Ordinal(10)] 
		[RED("reactionCb")] 
		public CUInt32 ReactionCb
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
		public CHandle<gameIBlackboard> PuppetBlackboard
		{
			get => GetProperty(ref _puppetBlackboard);
			set => SetProperty(ref _puppetBlackboard, value);
		}

		[Ordinal(15)] 
		[RED("playerTakedownStateCallbackID")] 
		public CUInt32 PlayerTakedownStateCallbackID
		{
			get => GetProperty(ref _playerTakedownStateCallbackID);
			set => SetProperty(ref _playerTakedownStateCallbackID, value);
		}

		[Ordinal(16)] 
		[RED("playerUpperBodyStateCallbackID")] 
		public CUInt32 PlayerUpperBodyStateCallbackID
		{
			get => GetProperty(ref _playerUpperBodyStateCallbackID);
			set => SetProperty(ref _playerUpperBodyStateCallbackID, value);
		}

		[Ordinal(17)] 
		[RED("playerCarryingStateCallbackID")] 
		public CUInt32 PlayerCarryingStateCallbackID
		{
			get => GetProperty(ref _playerCarryingStateCallbackID);
			set => SetProperty(ref _playerCarryingStateCallbackID, value);
		}

		[Ordinal(18)] 
		[RED("playerInPerception")] 
		public wCHandle<PlayerPuppet> PlayerInPerception
		{
			get => GetProperty(ref _playerInPerception);
			set => SetProperty(ref _playerInPerception, value);
		}

		public senseComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
