using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questVehicleSummoned_ConditionType : questIVehicleConditionType
	{
		private CEnum<vehicleESummonedVehicleType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<vehicleESummonedVehicleType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
