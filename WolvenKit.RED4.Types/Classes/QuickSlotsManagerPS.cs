using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickSlotsManagerPS : gameComponentPS
	{
		private CEnum<gamedataVehicleType> _activeVehicleType;

		[Ordinal(0)] 
		[RED("activeVehicleType")] 
		public CEnum<gamedataVehicleType> ActiveVehicleType
		{
			get => GetProperty(ref _activeVehicleType);
			set => SetProperty(ref _activeVehicleType, value);
		}

		public QuickSlotsManagerPS()
		{
			_activeVehicleType = new() { Value = Enums.gamedataVehicleType.Car };
		}
	}
}
