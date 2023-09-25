using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerCombatController : IScriptable
	{
		[Ordinal(0)] 
		[RED("gameplayActiveFlagsRefreshPolicy")] 
		public PlayerCombatControllerRefreshPolicy GameplayActiveFlagsRefreshPolicy
		{
			get => GetPropertyValue<PlayerCombatControllerRefreshPolicy>();
			set => SetPropertyValue<PlayerCombatControllerRefreshPolicy>(value);
		}

		[Ordinal(1)] 
		[RED("blackboardIds")] 
		public PlayerCombatControllerBBIds BlackboardIds
		{
			get => GetPropertyValue<PlayerCombatControllerBBIds>();
			set => SetPropertyValue<PlayerCombatControllerBBIds>(value);
		}

		[Ordinal(2)] 
		[RED("blackboardValuesIds")] 
		public PlayerCombatControllerBBValuesIds BlackboardValuesIds
		{
			get => GetPropertyValue<PlayerCombatControllerBBValuesIds>();
			set => SetPropertyValue<PlayerCombatControllerBBValuesIds>(value);
		}

		[Ordinal(3)] 
		[RED("blackboardListenersFunctions")] 
		public PlayerCombatControllerBlackboardListenersFunctions BlackboardListenersFunctions
		{
			get => GetPropertyValue<PlayerCombatControllerBlackboardListenersFunctions>();
			set => SetPropertyValue<PlayerCombatControllerBlackboardListenersFunctions>(value);
		}

		[Ordinal(4)] 
		[RED("blackboardListeners")] 
		public PlayerCombatControllerBBListeners BlackboardListeners
		{
			get => GetPropertyValue<PlayerCombatControllerBBListeners>();
			set => SetPropertyValue<PlayerCombatControllerBBListeners>(value);
		}

		[Ordinal(5)] 
		[RED("delayEventsIds")] 
		public PlayerCombatControllerDelayCallbacksIds DelayEventsIds
		{
			get => GetPropertyValue<PlayerCombatControllerDelayCallbacksIds>();
			set => SetPropertyValue<PlayerCombatControllerDelayCallbacksIds>(value);
		}

		[Ordinal(6)] 
		[RED("gameplayActiveFlags")] 
		public PlayerCombatControllerActiveFlags GameplayActiveFlags
		{
			get => GetPropertyValue<PlayerCombatControllerActiveFlags>();
			set => SetPropertyValue<PlayerCombatControllerActiveFlags>(value);
		}

		[Ordinal(7)] 
		[RED("otherVars")] 
		public PlayerCombatControllerOtherVars OtherVars
		{
			get => GetPropertyValue<PlayerCombatControllerOtherVars>();
			set => SetPropertyValue<PlayerCombatControllerOtherVars>(value);
		}

		[Ordinal(8)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public PlayerCombatController()
		{
			GameplayActiveFlagsRefreshPolicy = new PlayerCombatControllerRefreshPolicy();
			BlackboardIds = new PlayerCombatControllerBBIds();
			BlackboardValuesIds = new PlayerCombatControllerBBValuesIds { CrouchActive = new gamebbScriptID_Int32() };
			BlackboardListenersFunctions = new PlayerCombatControllerBlackboardListenersFunctions();
			BlackboardListeners = new PlayerCombatControllerBBListeners();
			DelayEventsIds = new PlayerCombatControllerDelayCallbacksIds { Crouch = new gameDelayID() };
			GameplayActiveFlags = new PlayerCombatControllerActiveFlags();
			OtherVars = new PlayerCombatControllerOtherVars();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
