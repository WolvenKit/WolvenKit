using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerCombatController : IScriptable
	{
		private PlayerCombatControllerRefreshPolicy _gameplayActiveFlagsRefreshPolicy;
		private PlayerCombatControllerBBIds _blackboardIds;
		private PlayerCombatControllerBBValuesIds _blackboardValuesIds;
		private PlayerCombatControllerBlackboardListenersFunctions _blackboardListenersFunctions;
		private PlayerCombatControllerBBListeners _blackboardListeners;
		private PlayerCombatControllerDelayCallbacksIds _delayEventsIds;
		private PlayerCombatControllerActiveFlags _gameplayActiveFlags;
		private PlayerCombatControllerOtherVars _otherVars;
		private CWeakHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("gameplayActiveFlagsRefreshPolicy")] 
		public PlayerCombatControllerRefreshPolicy GameplayActiveFlagsRefreshPolicy
		{
			get => GetProperty(ref _gameplayActiveFlagsRefreshPolicy);
			set => SetProperty(ref _gameplayActiveFlagsRefreshPolicy, value);
		}

		[Ordinal(1)] 
		[RED("blackboardIds")] 
		public PlayerCombatControllerBBIds BlackboardIds
		{
			get => GetProperty(ref _blackboardIds);
			set => SetProperty(ref _blackboardIds, value);
		}

		[Ordinal(2)] 
		[RED("blackboardValuesIds")] 
		public PlayerCombatControllerBBValuesIds BlackboardValuesIds
		{
			get => GetProperty(ref _blackboardValuesIds);
			set => SetProperty(ref _blackboardValuesIds, value);
		}

		[Ordinal(3)] 
		[RED("blackboardListenersFunctions")] 
		public PlayerCombatControllerBlackboardListenersFunctions BlackboardListenersFunctions
		{
			get => GetProperty(ref _blackboardListenersFunctions);
			set => SetProperty(ref _blackboardListenersFunctions, value);
		}

		[Ordinal(4)] 
		[RED("blackboardListeners")] 
		public PlayerCombatControllerBBListeners BlackboardListeners
		{
			get => GetProperty(ref _blackboardListeners);
			set => SetProperty(ref _blackboardListeners, value);
		}

		[Ordinal(5)] 
		[RED("delayEventsIds")] 
		public PlayerCombatControllerDelayCallbacksIds DelayEventsIds
		{
			get => GetProperty(ref _delayEventsIds);
			set => SetProperty(ref _delayEventsIds, value);
		}

		[Ordinal(6)] 
		[RED("gameplayActiveFlags")] 
		public PlayerCombatControllerActiveFlags GameplayActiveFlags
		{
			get => GetProperty(ref _gameplayActiveFlags);
			set => SetProperty(ref _gameplayActiveFlags, value);
		}

		[Ordinal(7)] 
		[RED("otherVars")] 
		public PlayerCombatControllerOtherVars OtherVars
		{
			get => GetProperty(ref _otherVars);
			set => SetProperty(ref _otherVars, value);
		}

		[Ordinal(8)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}
	}
}
