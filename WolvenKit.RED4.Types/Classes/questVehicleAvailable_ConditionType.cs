using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questVehicleAvailable_ConditionType : questIVehicleConditionType
	{
		[Ordinal(0)] 
		[RED("vehicleType")] 
		public CEnum<questAvailableVehicleType> VehicleType
		{
			get => GetPropertyValue<CEnum<questAvailableVehicleType>>();
			set => SetPropertyValue<CEnum<questAvailableVehicleType>>(value);
		}

		[Ordinal(1)] 
		[RED("vehicleName")] 
		public CString VehicleName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public questVehicleAvailable_ConditionType()
		{
			VehicleType = Enums.questAvailableVehicleType.SpecificVehicle;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
