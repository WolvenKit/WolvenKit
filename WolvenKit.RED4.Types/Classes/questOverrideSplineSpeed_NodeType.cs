using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questOverrideSplineSpeed_NodeType : questIVehicleManagerNodeType
	{
		private gameEntityReference _vehicleRef;
		private CFloat _speed;
		private CFloat _adjustTime;

		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetProperty(ref _vehicleRef);
			set => SetProperty(ref _vehicleRef, value);
		}

		[Ordinal(1)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		[Ordinal(2)] 
		[RED("adjustTime")] 
		public CFloat AdjustTime
		{
			get => GetProperty(ref _adjustTime);
			set => SetProperty(ref _adjustTime, value);
		}
	}
}
