using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficCollisionSphere : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("worldPos")] 
		public Vector3 WorldPos
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(1)] 
		[RED("direction")] 
		public Vector3 Direction
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(2)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("userData")] 
		public CUInt64 UserData
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(4)] 
		[RED("flags")] 
		public CUInt8 Flags
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public worldTrafficCollisionSphere()
		{
			WorldPos = new() { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity };
			Direction = new() { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity };
			Flags = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
