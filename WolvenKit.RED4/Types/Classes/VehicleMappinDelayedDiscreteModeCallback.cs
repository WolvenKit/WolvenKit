using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleMappinDelayedDiscreteModeCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		[Ordinal(0)] 
		[RED("vehicleMappinComponent")] 
		public CWeakHandle<VehicleMappinComponent> VehicleMappinComponent
		{
			get => GetPropertyValue<CWeakHandle<VehicleMappinComponent>>();
			set => SetPropertyValue<CWeakHandle<VehicleMappinComponent>>(value);
		}

		public VehicleMappinDelayedDiscreteModeCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
