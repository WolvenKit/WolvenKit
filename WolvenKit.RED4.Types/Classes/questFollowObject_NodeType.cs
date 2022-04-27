using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questFollowObject_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("followObjectRef")] 
		public gameEntityReference FollowObjectRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(2)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(3)] 
		[RED("positionLerpSpeed")] 
		public CFloat PositionLerpSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("rotationLerpSpeed")] 
		public CFloat RotationLerpSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public questFollowObject_NodeType()
		{
			VehicleRef = new() { Names = new() };
			FollowObjectRef = new() { Names = new() };
			Offset = new();
			PositionLerpSpeed = 1.000000F;
			RotationLerpSpeed = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
