using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiDriverCombatHUDGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("inWeaponizedVehicle")] 
		public CBool InWeaponizedVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("inDriverCombat")] 
		public CBool InDriverCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("inReloadState")] 
		public CBool InReloadState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("inSafeState")] 
		public CBool InSafeState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("crosshairBrackets")] 
		public inkWidgetReference CrosshairBrackets
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("crosshairBracketsFlairLeft")] 
		public inkWidgetReference CrosshairBracketsFlairLeft
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("crosshairBracketsFlairRight")] 
		public inkWidgetReference CrosshairBracketsFlairRight
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("bracketsTransitionDetailsWidgetList")] 
		public CArray<inkWidgetReference> BracketsTransitionDetailsWidgetList
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(17)] 
		[RED("crosshairBracketsMinSize")] 
		public Vector2 CrosshairBracketsMinSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(18)] 
		[RED("crosshairBracketsInstantSnapValue")] 
		public CFloat CrosshairBracketsInstantSnapValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("crosshairBracketsInOutTransitionTime")] 
		public CFloat CrosshairBracketsInOutTransitionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("crosshairBracketsIntroSizeMultiplier")] 
		public CFloat CrosshairBracketsIntroSizeMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("crosshairBracketsTrail")] 
		public inkWidgetReference CrosshairBracketsTrail
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("crosshairBracketsTrailTransitionTime")] 
		public CFloat CrosshairBracketsTrailTransitionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(23)] 
		[RED("crosshairReducedOpacity")] 
		public CFloat CrosshairReducedOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(24)] 
		[RED("unifomSafeZone")] 
		public CFloat UnifomSafeZone
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(26)] 
		[RED("psmBlackboard")] 
		public CWeakHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(27)] 
		[RED("psmWeaponCallback")] 
		public CHandle<redCallbackObject> PsmWeaponCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(28)] 
		[RED("uiActiveVehicleFPPRearviewCameraActivatedCallback")] 
		public CHandle<redCallbackObject> UiActiveVehicleFPPRearviewCameraActivatedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(29)] 
		[RED("reloadingAnimProxy")] 
		public CHandle<inkanimProxy> ReloadingAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(30)] 
		[RED("vehicleFPPRearviewCamera")] 
		public inkWidgetReference VehicleFPPRearviewCamera
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("vehicleManufacturer")] 
		public inkImageWidgetReference VehicleManufacturer
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("debugTuningStatusText")] 
		public inkTextWidgetReference DebugTuningStatusText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public gameuiDriverCombatHUDGameController()
		{
			CrosshairBrackets = new inkWidgetReference();
			CrosshairBracketsFlairLeft = new inkWidgetReference();
			CrosshairBracketsFlairRight = new inkWidgetReference();
			BracketsTransitionDetailsWidgetList = new();
			CrosshairBracketsMinSize = new Vector2 { X = 32.000000F, Y = 32.000000F };
			CrosshairBracketsInstantSnapValue = 0.100000F;
			CrosshairBracketsInOutTransitionTime = 0.250000F;
			CrosshairBracketsIntroSizeMultiplier = 1.200000F;
			CrosshairBracketsTrail = new inkWidgetReference();
			CrosshairBracketsTrailTransitionTime = 0.250000F;
			CrosshairReducedOpacity = 0.200000F;
			UnifomSafeZone = 0.900000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
