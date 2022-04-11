using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleListItemData : IScriptable
	{
		[Ordinal(0)] 
		[RED("displayName")] 
		public CName DisplayName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public vehiclePlayerVehicle Data
		{
			get => GetPropertyValue<vehiclePlayerVehicle>();
			set => SetPropertyValue<vehiclePlayerVehicle>(value);
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public CWeakHandle<gamedataUIIcon_Record> Icon
		{
			get => GetPropertyValue<CWeakHandle<gamedataUIIcon_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataUIIcon_Record>>(value);
		}

		public VehicleListItemData()
		{
			Data = new() { VehicleType = Enums.gamedataVehicleType.Invalid };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
