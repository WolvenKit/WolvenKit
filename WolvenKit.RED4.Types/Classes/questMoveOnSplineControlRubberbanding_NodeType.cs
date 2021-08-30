using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questMoveOnSplineControlRubberbanding_NodeType : questIVehicleManagerNodeType
	{
		private CBool _enable;
		private gameEntityReference _vehicleRef;
		private gameEntityReference _keepDistanceFromRef;
		private CFloat _distance;
		private CFloat _minSpeed;
		private CBool _reduceSpeedOnTurns;

		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		[Ordinal(1)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetProperty(ref _vehicleRef);
			set => SetProperty(ref _vehicleRef, value);
		}

		[Ordinal(2)] 
		[RED("keepDistanceFromRef")] 
		public gameEntityReference KeepDistanceFromRef
		{
			get => GetProperty(ref _keepDistanceFromRef);
			set => SetProperty(ref _keepDistanceFromRef, value);
		}

		[Ordinal(3)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetProperty(ref _distance);
			set => SetProperty(ref _distance, value);
		}

		[Ordinal(4)] 
		[RED("minSpeed")] 
		public CFloat MinSpeed
		{
			get => GetProperty(ref _minSpeed);
			set => SetProperty(ref _minSpeed, value);
		}

		[Ordinal(5)] 
		[RED("reduceSpeedOnTurns")] 
		public CBool ReduceSpeedOnTurns
		{
			get => GetProperty(ref _reduceSpeedOnTurns);
			set => SetProperty(ref _reduceSpeedOnTurns, value);
		}

		public questMoveOnSplineControlRubberbanding_NodeType()
		{
			_reduceSpeedOnTurns = true;
		}
	}
}
