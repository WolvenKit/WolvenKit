using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AimingContextDecisions : InputContextTransitionDecisions
	{
		[Ordinal(0)] 
		[RED("leftHandChargeCallbackID")] 
		public CHandle<redCallbackObject> LeftHandChargeCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(1)] 
		[RED("upperBodyCallbackID")] 
		public CHandle<redCallbackObject> UpperBodyCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(2)] 
		[RED("meleeCallbackID")] 
		public CHandle<redCallbackObject> MeleeCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(3)] 
		[RED("vehicleCombatCallbackID")] 
		public CHandle<redCallbackObject> VehicleCombatCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(4)] 
		[RED("leftHandCharge")] 
		public CBool LeftHandCharge
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("isAiming")] 
		public CBool IsAiming
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("meleeBlockActive")] 
		public CBool MeleeBlockActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("isVehicleCombat")] 
		public CBool IsVehicleCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("StateGameScriptInterfaceHACK")] 
		public CHandle<gamestateMachineGameScriptInterface> StateGameScriptInterfaceHACK
		{
			get => GetPropertyValue<CHandle<gamestateMachineGameScriptInterface>>();
			set => SetPropertyValue<CHandle<gamestateMachineGameScriptInterface>>(value);
		}

		[Ordinal(9)] 
		[RED("context")] 
		public CHandle<gamestateMachineStateContextScript> Context
		{
			get => GetPropertyValue<CHandle<gamestateMachineStateContextScript>>();
			set => SetPropertyValue<CHandle<gamestateMachineStateContextScript>>(value);
		}

		public AimingContextDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
