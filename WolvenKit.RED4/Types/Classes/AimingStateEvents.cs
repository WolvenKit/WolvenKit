using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AimingStateEvents : UpperBodyEventsTransition
	{
		[Ordinal(6)] 
		[RED("aim")] 
		public CHandle<gameweaponAnimFeature_AimPlayer> Aim
		{
			get => GetPropertyValue<CHandle<gameweaponAnimFeature_AimPlayer>>();
			set => SetPropertyValue<CHandle<gameweaponAnimFeature_AimPlayer>>(value);
		}

		[Ordinal(7)] 
		[RED("posAnimFeature")] 
		public CHandle<AnimFeature_ProceduralIronsightData> PosAnimFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_ProceduralIronsightData>>();
			set => SetPropertyValue<CHandle<AnimFeature_ProceduralIronsightData>>(value);
		}

		[Ordinal(8)] 
		[RED("statusEffectListener")] 
		public CHandle<DefaultTransitionStatusEffectListener> StatusEffectListener
		{
			get => GetPropertyValue<CHandle<DefaultTransitionStatusEffectListener>>();
			set => SetPropertyValue<CHandle<DefaultTransitionStatusEffectListener>>(value);
		}

		[Ordinal(9)] 
		[RED("weapon")] 
		public CWeakHandle<gameweaponObject> Weapon
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		[Ordinal(10)] 
		[RED("executionOwner")] 
		public CWeakHandle<gameObject> ExecutionOwner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(11)] 
		[RED("mouseZoomLevel")] 
		public CFloat MouseZoomLevel
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("zoomLevelNum")] 
		public CInt32 ZoomLevelNum
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(13)] 
		[RED("numZoomLevels")] 
		public CInt32 NumZoomLevels
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(14)] 
		[RED("delayAimSnap")] 
		public CInt32 DelayAimSnap
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(15)] 
		[RED("isAiming")] 
		public CBool IsAiming
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("aimInTimeRemaining")] 
		public CFloat AimInTimeRemaining
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("aimBroadcast")] 
		public CBool AimBroadcast
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("zoomLevel")] 
		public CFloat ZoomLevel
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("finalZoomLevel")] 
		public CFloat FinalZoomLevel
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("previousZoomLevel")] 
		public CFloat PreviousZoomLevel
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("currentZoomLevel")] 
		public CFloat CurrentZoomLevel
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("timeToBlendZoom")] 
		public CFloat TimeToBlendZoom
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(23)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(24)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("itemChanged")] 
		public CBool ItemChanged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("firearmsNoUnequipNoSwitch")] 
		public CBool FirearmsNoUnequipNoSwitch
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("shootingRangeCompetition")] 
		public CBool ShootingRangeCompetition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("weaponHasPerfectAim")] 
		public CBool WeaponHasPerfectAim
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("attachmentSlotListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> AttachmentSlotListener
		{
			get => GetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>();
			set => SetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>(value);
		}

		public AimingStateEvents()
		{
			MouseZoomLevel = 100000.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
