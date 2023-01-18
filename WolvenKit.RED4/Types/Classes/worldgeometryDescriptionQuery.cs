using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldgeometryDescriptionQuery : IScriptable
	{
		[Ordinal(0)] 
		[RED("refPosition")] 
		public Vector4 RefPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("refDirection")] 
		public Vector4 RefDirection
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("refUp")] 
		public Vector4 RefUp
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(3)] 
		[RED("primitiveDimension")] 
		public Vector4 PrimitiveDimension
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(4)] 
		[RED("primitiveRotation")] 
		public Quaternion PrimitiveRotation
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		[Ordinal(5)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("maxExtent")] 
		public CFloat MaxExtent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("raycastStartDistance")] 
		public CFloat RaycastStartDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("probingPrecision")] 
		public CFloat ProbingPrecision
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("probingMaxDistanceDiff")] 
		public CFloat ProbingMaxDistanceDiff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("maxProbes")] 
		public CUInt32 MaxProbes
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(11)] 
		[RED("probeDimensions")] 
		public Vector4 ProbeDimensions
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(12)] 
		[RED("filter")] 
		public physicsQueryFilter Filter
		{
			get => GetPropertyValue<physicsQueryFilter>();
			set => SetPropertyValue<physicsQueryFilter>(value);
		}

		[Ordinal(13)] 
		[RED("flags")] 
		public CUInt32 Flags
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public worldgeometryDescriptionQuery()
		{
			RefPosition = new();
			RefDirection = new();
			RefUp = new() { Z = 1.000000F };
			PrimitiveDimension = new() { X = 1.000000F, Y = 1.000000F, Z = 1.000000F, W = 1.000000F };
			PrimitiveRotation = new() { R = 1.000000F };
			MaxDistance = 2.000000F;
			MaxExtent = 1.000000F;
			RaycastStartDistance = 0.500000F;
			ProbingPrecision = 0.010000F;
			ProbingMaxDistanceDiff = 0.800000F;
			MaxProbes = 100;
			ProbeDimensions = new() { X = 0.400000F, Y = -1.000000F, Z = -1.000000F, W = 1.000000F };
			Filter = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
