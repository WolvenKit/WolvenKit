using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickSlotsManagerPS : gameComponentPS
	{
		[Ordinal(0)] 
		[RED("activeVehicleType")] 
		public CEnum<gamedataVehicleType> ActiveVehicleType
		{
			get => GetPropertyValue<CEnum<gamedataVehicleType>>();
			set => SetPropertyValue<CEnum<gamedataVehicleType>>(value);
		}

		public QuickSlotsManagerPS()
		{
			ActiveVehicleType = Enums.gamedataVehicleType.Car;
		}
	}
}
