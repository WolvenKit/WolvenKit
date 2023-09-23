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
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
