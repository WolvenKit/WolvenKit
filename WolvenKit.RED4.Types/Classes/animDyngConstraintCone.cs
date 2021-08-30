using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animDyngConstraintCone : animIDyngConstraint
	{
		private animTransformIndex _constrainedBone;
		private animTransformIndex _coneAttachmentBone;
		private QsTransform _coneTransformLS;
		private CEnum<animPendulumConstraintType> _constraintType;
		private CFloat _halfOfMaxApertureAngle;
		private CEnum<animPendulumProjectionType> _projectionType;
		private CFloat _collisionCapsuleRadius;
		private CFloat _collisionCapsuleHeightExtent;

		[Ordinal(1)] 
		[RED("constrainedBone")] 
		public animTransformIndex ConstrainedBone
		{
			get => GetProperty(ref _constrainedBone);
			set => SetProperty(ref _constrainedBone, value);
		}

		[Ordinal(2)] 
		[RED("coneAttachmentBone")] 
		public animTransformIndex ConeAttachmentBone
		{
			get => GetProperty(ref _coneAttachmentBone);
			set => SetProperty(ref _coneAttachmentBone, value);
		}

		[Ordinal(3)] 
		[RED("coneTransformLS")] 
		public QsTransform ConeTransformLS
		{
			get => GetProperty(ref _coneTransformLS);
			set => SetProperty(ref _coneTransformLS, value);
		}

		[Ordinal(4)] 
		[RED("constraintType")] 
		public CEnum<animPendulumConstraintType> ConstraintType
		{
			get => GetProperty(ref _constraintType);
			set => SetProperty(ref _constraintType, value);
		}

		[Ordinal(5)] 
		[RED("halfOfMaxApertureAngle")] 
		public CFloat HalfOfMaxApertureAngle
		{
			get => GetProperty(ref _halfOfMaxApertureAngle);
			set => SetProperty(ref _halfOfMaxApertureAngle, value);
		}

		[Ordinal(6)] 
		[RED("projectionType")] 
		public CEnum<animPendulumProjectionType> ProjectionType
		{
			get => GetProperty(ref _projectionType);
			set => SetProperty(ref _projectionType, value);
		}

		[Ordinal(7)] 
		[RED("collisionCapsuleRadius")] 
		public CFloat CollisionCapsuleRadius
		{
			get => GetProperty(ref _collisionCapsuleRadius);
			set => SetProperty(ref _collisionCapsuleRadius, value);
		}

		[Ordinal(8)] 
		[RED("collisionCapsuleHeightExtent")] 
		public CFloat CollisionCapsuleHeightExtent
		{
			get => GetProperty(ref _collisionCapsuleHeightExtent);
			set => SetProperty(ref _collisionCapsuleHeightExtent, value);
		}

		public animDyngConstraintCone()
		{
			_halfOfMaxApertureAngle = 45.000000F;
			_projectionType = new() { Value = Enums.animPendulumProjectionType.ShortestPathRotational };
		}
	}
}
