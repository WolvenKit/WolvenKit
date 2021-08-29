using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldgeometryDescriptionQuery : IScriptable
	{
		private Vector4 _refPosition;
		private Vector4 _refDirection;
		private Vector4 _refUp;
		private Vector4 _primitiveDimension;
		private Quaternion _primitiveRotation;
		private CFloat _maxDistance;
		private CFloat _maxExtent;
		private CFloat _raycastStartDistance;
		private CFloat _probingPrecision;
		private CFloat _probingMaxDistanceDiff;
		private CUInt32 _maxProbes;
		private Vector4 _probeDimensions;
		private physicsQueryFilter _filter;
		private CUInt32 _flags;

		[Ordinal(0)] 
		[RED("refPosition")] 
		public Vector4 RefPosition
		{
			get => GetProperty(ref _refPosition);
			set => SetProperty(ref _refPosition, value);
		}

		[Ordinal(1)] 
		[RED("refDirection")] 
		public Vector4 RefDirection
		{
			get => GetProperty(ref _refDirection);
			set => SetProperty(ref _refDirection, value);
		}

		[Ordinal(2)] 
		[RED("refUp")] 
		public Vector4 RefUp
		{
			get => GetProperty(ref _refUp);
			set => SetProperty(ref _refUp, value);
		}

		[Ordinal(3)] 
		[RED("primitiveDimension")] 
		public Vector4 PrimitiveDimension
		{
			get => GetProperty(ref _primitiveDimension);
			set => SetProperty(ref _primitiveDimension, value);
		}

		[Ordinal(4)] 
		[RED("primitiveRotation")] 
		public Quaternion PrimitiveRotation
		{
			get => GetProperty(ref _primitiveRotation);
			set => SetProperty(ref _primitiveRotation, value);
		}

		[Ordinal(5)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get => GetProperty(ref _maxDistance);
			set => SetProperty(ref _maxDistance, value);
		}

		[Ordinal(6)] 
		[RED("maxExtent")] 
		public CFloat MaxExtent
		{
			get => GetProperty(ref _maxExtent);
			set => SetProperty(ref _maxExtent, value);
		}

		[Ordinal(7)] 
		[RED("raycastStartDistance")] 
		public CFloat RaycastStartDistance
		{
			get => GetProperty(ref _raycastStartDistance);
			set => SetProperty(ref _raycastStartDistance, value);
		}

		[Ordinal(8)] 
		[RED("probingPrecision")] 
		public CFloat ProbingPrecision
		{
			get => GetProperty(ref _probingPrecision);
			set => SetProperty(ref _probingPrecision, value);
		}

		[Ordinal(9)] 
		[RED("probingMaxDistanceDiff")] 
		public CFloat ProbingMaxDistanceDiff
		{
			get => GetProperty(ref _probingMaxDistanceDiff);
			set => SetProperty(ref _probingMaxDistanceDiff, value);
		}

		[Ordinal(10)] 
		[RED("maxProbes")] 
		public CUInt32 MaxProbes
		{
			get => GetProperty(ref _maxProbes);
			set => SetProperty(ref _maxProbes, value);
		}

		[Ordinal(11)] 
		[RED("probeDimensions")] 
		public Vector4 ProbeDimensions
		{
			get => GetProperty(ref _probeDimensions);
			set => SetProperty(ref _probeDimensions, value);
		}

		[Ordinal(12)] 
		[RED("filter")] 
		public physicsQueryFilter Filter
		{
			get => GetProperty(ref _filter);
			set => SetProperty(ref _filter, value);
		}

		[Ordinal(13)] 
		[RED("flags")] 
		public CUInt32 Flags
		{
			get => GetProperty(ref _flags);
			set => SetProperty(ref _flags, value);
		}
	}
}
