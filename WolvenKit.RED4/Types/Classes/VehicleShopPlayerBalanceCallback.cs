using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleShopPlayerBalanceCallback : gameInventoryScriptCallback
	{
		[Ordinal(1)] 
		[RED("owner")] 
		public CWeakHandle<gameuiVehicleShopGameController> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameuiVehicleShopGameController>>();
			set => SetPropertyValue<CWeakHandle<gameuiVehicleShopGameController>>(value);
		}

		public VehicleShopPlayerBalanceCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
