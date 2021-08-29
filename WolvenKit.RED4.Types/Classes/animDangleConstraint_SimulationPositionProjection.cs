using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animDangleConstraint_SimulationPositionProjection : animDangleConstraint_SimulationSingleBone
	{
		private CFloat _collisionCapsuleRadius;
		private CFloat _collisionCapsuleHeightExtent;
		private Vector3 _collisionCapsuleAxisLS;
		private animTransformIndex _directionReferenceBone;
		private CEnum<animPositionProjectionType> _projectionType;

		[Ordinal(14)] 
		[RED("collisionCapsuleRadius")] 
		public CFloat CollisionCapsuleRadius
		{
			get => GetProperty(ref _collisionCapsuleRadius);
			set => SetProperty(ref _collisionCapsuleRadius, value);
		}

		[Ordinal(15)] 
		[RED("collisionCapsuleHeightExtent")] 
		public CFloat CollisionCapsuleHeightExtent
		{
			get => GetProperty(ref _collisionCapsuleHeightExtent);
			set => SetProperty(ref _collisionCapsuleHeightExtent, value);
		}

		[Ordinal(16)] 
		[RED("collisionCapsuleAxisLS")] 
		public Vector3 CollisionCapsuleAxisLS
		{
			get => GetProperty(ref _collisionCapsuleAxisLS);
			set => SetProperty(ref _collisionCapsuleAxisLS, value);
		}

		[Ordinal(17)] 
		[RED("directionReferenceBone")] 
		public animTransformIndex DirectionReferenceBone
		{
			get => GetProperty(ref _directionReferenceBone);
			set => SetProperty(ref _directionReferenceBone, value);
		}

		[Ordinal(18)] 
		[RED("projectionType")] 
		public CEnum<animPositionProjectionType> ProjectionType
		{
			get => GetProperty(ref _projectionType);
			set => SetProperty(ref _projectionType, value);
		}
	}
}
