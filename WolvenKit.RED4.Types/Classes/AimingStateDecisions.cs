using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AimingStateDecisions : UpperBodyTransition
	{
		private CArray<CHandle<redCallbackObject>> _callbackIDs;
		private CWeakHandle<gameObject> _executionOwner;
		private CHandle<DefaultTransitionStatListener> _statListener;
		private CHandle<DefaultTransitionStatusEffectListener> _statusEffectListener;
		private CHandle<gameAttachmentSlotsScriptListener> _attachmentSlotListener;
		private CInt32 _sceneTier;
		private CInt32 _vehicleState;
		private CInt32 _highLevelState;
		private CInt32 _combatGadgetState;
		private CInt32 _takedownState;
		private CInt32 _weaponState;
		private CBool _cameraAimPressed;
		private CBool _sceneAimForced;
		private CBool _shouldAim;
		private CBool _hasRightHandItemEquipped;
		private CBool _isDead;
		private CBool _isWeaponBlockingAiming;
		private CBool _visionModeActive;
		private CBool _isDodging;
		private CBool _hasThrowableMeleeWeapon;
		private CBool _canAimWhileDodging;
		private CBool _canThrowWeapon;
		private CBool _aimForced;
		private CBool _beingCreated;
		private CFloat _mouseZoomLevel;

		[Ordinal(0)] 
		[RED("callbackIDs")] 
		public CArray<CHandle<redCallbackObject>> CallbackIDs
		{
			get => GetProperty(ref _callbackIDs);
			set => SetProperty(ref _callbackIDs, value);
		}

		[Ordinal(1)] 
		[RED("executionOwner")] 
		public CWeakHandle<gameObject> ExecutionOwner
		{
			get => GetProperty(ref _executionOwner);
			set => SetProperty(ref _executionOwner, value);
		}

		[Ordinal(2)] 
		[RED("statListener")] 
		public CHandle<DefaultTransitionStatListener> StatListener
		{
			get => GetProperty(ref _statListener);
			set => SetProperty(ref _statListener, value);
		}

		[Ordinal(3)] 
		[RED("statusEffectListener")] 
		public CHandle<DefaultTransitionStatusEffectListener> StatusEffectListener
		{
			get => GetProperty(ref _statusEffectListener);
			set => SetProperty(ref _statusEffectListener, value);
		}

		[Ordinal(4)] 
		[RED("attachmentSlotListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> AttachmentSlotListener
		{
			get => GetProperty(ref _attachmentSlotListener);
			set => SetProperty(ref _attachmentSlotListener, value);
		}

		[Ordinal(5)] 
		[RED("sceneTier")] 
		public CInt32 SceneTier
		{
			get => GetProperty(ref _sceneTier);
			set => SetProperty(ref _sceneTier, value);
		}

		[Ordinal(6)] 
		[RED("vehicleState")] 
		public CInt32 VehicleState
		{
			get => GetProperty(ref _vehicleState);
			set => SetProperty(ref _vehicleState, value);
		}

		[Ordinal(7)] 
		[RED("highLevelState")] 
		public CInt32 HighLevelState
		{
			get => GetProperty(ref _highLevelState);
			set => SetProperty(ref _highLevelState, value);
		}

		[Ordinal(8)] 
		[RED("combatGadgetState")] 
		public CInt32 CombatGadgetState
		{
			get => GetProperty(ref _combatGadgetState);
			set => SetProperty(ref _combatGadgetState, value);
		}

		[Ordinal(9)] 
		[RED("takedownState")] 
		public CInt32 TakedownState
		{
			get => GetProperty(ref _takedownState);
			set => SetProperty(ref _takedownState, value);
		}

		[Ordinal(10)] 
		[RED("weaponState")] 
		public CInt32 WeaponState
		{
			get => GetProperty(ref _weaponState);
			set => SetProperty(ref _weaponState, value);
		}

		[Ordinal(11)] 
		[RED("cameraAimPressed")] 
		public CBool CameraAimPressed
		{
			get => GetProperty(ref _cameraAimPressed);
			set => SetProperty(ref _cameraAimPressed, value);
		}

		[Ordinal(12)] 
		[RED("sceneAimForced")] 
		public CBool SceneAimForced
		{
			get => GetProperty(ref _sceneAimForced);
			set => SetProperty(ref _sceneAimForced, value);
		}

		[Ordinal(13)] 
		[RED("shouldAim")] 
		public CBool ShouldAim
		{
			get => GetProperty(ref _shouldAim);
			set => SetProperty(ref _shouldAim, value);
		}

		[Ordinal(14)] 
		[RED("hasRightHandItemEquipped")] 
		public CBool HasRightHandItemEquipped
		{
			get => GetProperty(ref _hasRightHandItemEquipped);
			set => SetProperty(ref _hasRightHandItemEquipped, value);
		}

		[Ordinal(15)] 
		[RED("isDead")] 
		public CBool IsDead
		{
			get => GetProperty(ref _isDead);
			set => SetProperty(ref _isDead, value);
		}

		[Ordinal(16)] 
		[RED("isWeaponBlockingAiming")] 
		public CBool IsWeaponBlockingAiming
		{
			get => GetProperty(ref _isWeaponBlockingAiming);
			set => SetProperty(ref _isWeaponBlockingAiming, value);
		}

		[Ordinal(17)] 
		[RED("visionModeActive")] 
		public CBool VisionModeActive
		{
			get => GetProperty(ref _visionModeActive);
			set => SetProperty(ref _visionModeActive, value);
		}

		[Ordinal(18)] 
		[RED("isDodging")] 
		public CBool IsDodging
		{
			get => GetProperty(ref _isDodging);
			set => SetProperty(ref _isDodging, value);
		}

		[Ordinal(19)] 
		[RED("hasThrowableMeleeWeapon")] 
		public CBool HasThrowableMeleeWeapon
		{
			get => GetProperty(ref _hasThrowableMeleeWeapon);
			set => SetProperty(ref _hasThrowableMeleeWeapon, value);
		}

		[Ordinal(20)] 
		[RED("canAimWhileDodging")] 
		public CBool CanAimWhileDodging
		{
			get => GetProperty(ref _canAimWhileDodging);
			set => SetProperty(ref _canAimWhileDodging, value);
		}

		[Ordinal(21)] 
		[RED("canThrowWeapon")] 
		public CBool CanThrowWeapon
		{
			get => GetProperty(ref _canThrowWeapon);
			set => SetProperty(ref _canThrowWeapon, value);
		}

		[Ordinal(22)] 
		[RED("aimForced")] 
		public CBool AimForced
		{
			get => GetProperty(ref _aimForced);
			set => SetProperty(ref _aimForced, value);
		}

		[Ordinal(23)] 
		[RED("beingCreated")] 
		public CBool BeingCreated
		{
			get => GetProperty(ref _beingCreated);
			set => SetProperty(ref _beingCreated, value);
		}

		[Ordinal(24)] 
		[RED("mouseZoomLevel")] 
		public CFloat MouseZoomLevel
		{
			get => GetProperty(ref _mouseZoomLevel);
			set => SetProperty(ref _mouseZoomLevel, value);
		}

		public AimingStateDecisions()
		{
			_mouseZoomLevel = 100000.000000F;
		}
	}
}
