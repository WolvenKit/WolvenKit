using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questFollowObject_NodeType : questIVehicleManagerNodeType
	{
		private gameEntityReference _vehicleRef;
		private gameEntityReference _followObjectRef;
		private Vector3 _offset;
		private CFloat _positionLerpSpeed;
		private CFloat _rotationLerpSpeed;

		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetProperty(ref _vehicleRef);
			set => SetProperty(ref _vehicleRef, value);
		}

		[Ordinal(1)] 
		[RED("followObjectRef")] 
		public gameEntityReference FollowObjectRef
		{
			get => GetProperty(ref _followObjectRef);
			set => SetProperty(ref _followObjectRef, value);
		}

		[Ordinal(2)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(3)] 
		[RED("positionLerpSpeed")] 
		public CFloat PositionLerpSpeed
		{
			get => GetProperty(ref _positionLerpSpeed);
			set => SetProperty(ref _positionLerpSpeed, value);
		}

		[Ordinal(4)] 
		[RED("rotationLerpSpeed")] 
		public CFloat RotationLerpSpeed
		{
			get => GetProperty(ref _rotationLerpSpeed);
			set => SetProperty(ref _rotationLerpSpeed, value);
		}
	}
}
