using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerVisionModeController : IScriptable
	{
		[Ordinal(0)] 
		[RED("gameplayActiveFlagsRefreshPolicy")] 
		public PlayerVisionModeControllerRefreshPolicy GameplayActiveFlagsRefreshPolicy
		{
			get => GetPropertyValue<PlayerVisionModeControllerRefreshPolicy>();
			set => SetPropertyValue<PlayerVisionModeControllerRefreshPolicy>(value);
		}

		[Ordinal(1)] 
		[RED("blackboardIds")] 
		public PlayerVisionModeControllerBBIds BlackboardIds
		{
			get => GetPropertyValue<PlayerVisionModeControllerBBIds>();
			set => SetPropertyValue<PlayerVisionModeControllerBBIds>(value);
		}

		[Ordinal(2)] 
		[RED("blackboardValuesIds")] 
		public PlayerVisionModeControllerBBValuesIds BlackboardValuesIds
		{
			get => GetPropertyValue<PlayerVisionModeControllerBBValuesIds>();
			set => SetPropertyValue<PlayerVisionModeControllerBBValuesIds>(value);
		}

		[Ordinal(3)] 
		[RED("blackboardListenersFunctions")] 
		public PlayerVisionModeControllerBlackboardListenersFunctions BlackboardListenersFunctions
		{
			get => GetPropertyValue<PlayerVisionModeControllerBlackboardListenersFunctions>();
			set => SetPropertyValue<PlayerVisionModeControllerBlackboardListenersFunctions>(value);
		}

		[Ordinal(4)] 
		[RED("blackboardListeners")] 
		public PlayerVisionModeControllerBBListeners BlackboardListeners
		{
			get => GetPropertyValue<PlayerVisionModeControllerBBListeners>();
			set => SetPropertyValue<PlayerVisionModeControllerBBListeners>(value);
		}

		[Ordinal(5)] 
		[RED("gameplayActiveFlags")] 
		public PlayerVisionModeControllerActiveFlags GameplayActiveFlags
		{
			get => GetPropertyValue<PlayerVisionModeControllerActiveFlags>();
			set => SetPropertyValue<PlayerVisionModeControllerActiveFlags>(value);
		}

		[Ordinal(6)] 
		[RED("inputActionsNames")] 
		public PlayerVisionModeControllerInputActionsNames InputActionsNames
		{
			get => GetPropertyValue<PlayerVisionModeControllerInputActionsNames>();
			set => SetPropertyValue<PlayerVisionModeControllerInputActionsNames>(value);
		}

		[Ordinal(7)] 
		[RED("inputListeners")] 
		public PlayerVisionModeControllerInputListeners InputListeners
		{
			get => GetPropertyValue<PlayerVisionModeControllerInputListeners>();
			set => SetPropertyValue<PlayerVisionModeControllerInputListeners>(value);
		}

		[Ordinal(8)] 
		[RED("inputActiveFlags")] 
		public PlayerVisionModeControllerInputActiveFlags InputActiveFlags
		{
			get => GetPropertyValue<PlayerVisionModeControllerInputActiveFlags>();
			set => SetPropertyValue<PlayerVisionModeControllerInputActiveFlags>(value);
		}

		[Ordinal(9)] 
		[RED("otherVars")] 
		public PlayerVisionModeControllerOtherVars OtherVars
		{
			get => GetPropertyValue<PlayerVisionModeControllerOtherVars>();
			set => SetPropertyValue<PlayerVisionModeControllerOtherVars>(value);
		}

		[Ordinal(10)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public PlayerVisionModeController()
		{
			GameplayActiveFlagsRefreshPolicy = new PlayerVisionModeControllerRefreshPolicy();
			BlackboardIds = new PlayerVisionModeControllerBBIds();
			BlackboardValuesIds = new PlayerVisionModeControllerBBValuesIds { Kerenzikov = new gamebbScriptID_Int32(), RestrictedScene = new gamebbScriptID_Int32(), Dead = new gamebbScriptID_Int32(), Takedown = new gamebbScriptID_Int32(), DeviceTakeover = new gamebbScriptID_EntityID(), BraindanceFPP = new gamebbScriptID_Bool(), BraindanceActive = new gamebbScriptID_Bool(), VeryHardLanding = new gamebbScriptID_Int32(), IsBriefingActive = new gamebbScriptID_Bool() };
			BlackboardListenersFunctions = new PlayerVisionModeControllerBlackboardListenersFunctions();
			BlackboardListeners = new PlayerVisionModeControllerBBListeners();
			GameplayActiveFlags = new PlayerVisionModeControllerActiveFlags();
			InputActionsNames = new PlayerVisionModeControllerInputActionsNames();
			InputListeners = new PlayerVisionModeControllerInputListeners();
			InputActiveFlags = new PlayerVisionModeControllerInputActiveFlags();
			OtherVars = new PlayerVisionModeControllerOtherVars();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
