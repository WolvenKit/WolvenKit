using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiDriverCombatMountedPowerWeaponCrosshairGameController : gameuiCrosshairBaseGameController
	{
		[Ordinal(27)] 
		[RED("reticleLeft")] 
		public inkWidgetReference ReticleLeft
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("reticleRight")] 
		public inkWidgetReference ReticleRight
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("reticleStartingRange")] 
		public CFloat ReticleStartingRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(30)] 
		[RED("defaultOpacity")] 
		public CFloat DefaultOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(31)] 
		[RED("reducedOpacity")] 
		public CFloat ReducedOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(32)] 
		[RED("weaponList")] 
		public CArray<CWeakHandle<gameweaponObject>> WeaponList
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameweaponObject>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameweaponObject>>>(value);
		}

		[Ordinal(33)] 
		[RED("isTPP")] 
		public CBool IsTPP
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(34)] 
		[RED("uiActiveVehicleDataBlackboard")] 
		public CWeakHandle<gameIBlackboard> UiActiveVehicleDataBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(35)] 
		[RED("psmCombatStateChangedCallback")] 
		public CHandle<redCallbackObject> PsmCombatStateChangedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(36)] 
		[RED("uiActiveVehicleCameraChangedCallback")] 
		public CHandle<redCallbackObject> UiActiveVehicleCameraChangedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public gameuiDriverCombatMountedPowerWeaponCrosshairGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
