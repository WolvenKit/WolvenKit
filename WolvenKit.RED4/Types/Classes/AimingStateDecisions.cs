using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AimingStateDecisions : UpperBodyTransition
	{
		[Ordinal(0)] 
		[RED("callbackIDs")] 
		public CArray<CHandle<redCallbackObject>> CallbackIDs
		{
			get => GetPropertyValue<CArray<CHandle<redCallbackObject>>>();
			set => SetPropertyValue<CArray<CHandle<redCallbackObject>>>(value);
		}

		[Ordinal(1)] 
		[RED("executionOwner")] 
		public CWeakHandle<gameObject> ExecutionOwner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(2)] 
		[RED("statListener")] 
		public CHandle<DefaultTransitionStatListener> StatListener
		{
			get => GetPropertyValue<CHandle<DefaultTransitionStatListener>>();
			set => SetPropertyValue<CHandle<DefaultTransitionStatListener>>(value);
		}

		[Ordinal(3)] 
		[RED("statusEffectListener")] 
		public CHandle<DefaultTransitionStatusEffectListener> StatusEffectListener
		{
			get => GetPropertyValue<CHandle<DefaultTransitionStatusEffectListener>>();
			set => SetPropertyValue<CHandle<DefaultTransitionStatusEffectListener>>(value);
		}

		[Ordinal(4)] 
		[RED("attachmentSlotListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> AttachmentSlotListener
		{
			get => GetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>();
			set => SetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>(value);
		}

		[Ordinal(5)] 
		[RED("sceneTier")] 
		public CInt32 SceneTier
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("vehicleState")] 
		public CInt32 VehicleState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("highLevelState")] 
		public CInt32 HighLevelState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(8)] 
		[RED("combatGadgetState")] 
		public CInt32 CombatGadgetState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(9)] 
		[RED("takedownState")] 
		public CInt32 TakedownState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("weaponState")] 
		public CInt32 WeaponState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("cameraAimPressed")] 
		public CBool CameraAimPressed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("sceneAimForced")] 
		public CBool SceneAimForced
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("shouldAim")] 
		public CBool ShouldAim
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("hasRightHandItemEquipped")] 
		public CBool HasRightHandItemEquipped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("isDead")] 
		public CBool IsDead
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("isWeaponBlockingAiming")] 
		public CBool IsWeaponBlockingAiming
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("visionModeActive")] 
		public CBool VisionModeActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("isDodging")] 
		public CBool IsDodging
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("hasThrowableMeleeWeapon")] 
		public CBool HasThrowableMeleeWeapon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("canAimWhileDodging")] 
		public CBool CanAimWhileDodging
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("canThrowWeapon")] 
		public CBool CanThrowWeapon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("aimForced")] 
		public CBool AimForced
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("beingCreated")] 
		public CBool BeingCreated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("mouseZoomLevel")] 
		public CFloat MouseZoomLevel
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AimingStateDecisions()
		{
			CallbackIDs = new();
			MouseZoomLevel = 100000.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
