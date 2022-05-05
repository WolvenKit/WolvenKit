using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questVehicleSummoned_ConditionType : questIVehicleConditionType
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<vehicleESummonedVehicleType> Type
		{
			get => GetPropertyValue<CEnum<vehicleESummonedVehicleType>>();
			set => SetPropertyValue<CEnum<vehicleESummonedVehicleType>>(value);
		}

		public questVehicleSummoned_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
