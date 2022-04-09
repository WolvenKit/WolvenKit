using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CrouchDecisions : LocomotionGroundDecisions
	{
		[Ordinal(3)] 
		[RED("gameplaySettings")] 
		public CWeakHandle<GameplaySettingsSystem> GameplaySettings
		{
			get => GetPropertyValue<CWeakHandle<GameplaySettingsSystem>>();
			set => SetPropertyValue<CWeakHandle<GameplaySettingsSystem>>(value);
		}

		[Ordinal(4)] 
		[RED("executionOwner")] 
		public CWeakHandle<gameObject> ExecutionOwner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(5)] 
		[RED("callbackID")] 
		public CHandle<redCallbackObject> CallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(6)] 
		[RED("statusEffectListener")] 
		public CHandle<DefaultTransitionStatusEffectListener> StatusEffectListener
		{
			get => GetPropertyValue<CHandle<DefaultTransitionStatusEffectListener>>();
			set => SetPropertyValue<CHandle<DefaultTransitionStatusEffectListener>>(value);
		}

		[Ordinal(7)] 
		[RED("crouchPressed")] 
		public CBool CrouchPressed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("toggleCrouchPressed")] 
		public CBool ToggleCrouchPressed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("forcedCrouch")] 
		public CBool ForcedCrouch
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("controllingDevice")] 
		public CBool ControllingDevice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CrouchDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
