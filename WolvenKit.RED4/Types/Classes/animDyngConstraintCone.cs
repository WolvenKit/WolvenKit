using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animDyngConstraintCone : animIDyngConstraint
	{
		[Ordinal(1)] 
		[RED("constrainedBone")] 
		public animTransformIndex ConstrainedBone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(2)] 
		[RED("coneAttachmentBone")] 
		public animTransformIndex ConeAttachmentBone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(3)] 
		[RED("coneTransformLS")] 
		public QsTransform ConeTransformLS
		{
			get => GetPropertyValue<QsTransform>();
			set => SetPropertyValue<QsTransform>(value);
		}

		[Ordinal(4)] 
		[RED("constraintType")] 
		public CEnum<animPendulumConstraintType> ConstraintType
		{
			get => GetPropertyValue<CEnum<animPendulumConstraintType>>();
			set => SetPropertyValue<CEnum<animPendulumConstraintType>>(value);
		}

		[Ordinal(5)] 
		[RED("halfOfMaxApertureAngle")] 
		public CFloat HalfOfMaxApertureAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("projectionType")] 
		public CEnum<animPendulumProjectionType> ProjectionType
		{
			get => GetPropertyValue<CEnum<animPendulumProjectionType>>();
			set => SetPropertyValue<CEnum<animPendulumProjectionType>>(value);
		}

		[Ordinal(7)] 
		[RED("collisionCapsuleRadius")] 
		public CFloat CollisionCapsuleRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("collisionCapsuleHeightExtent")] 
		public CFloat CollisionCapsuleHeightExtent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animDyngConstraintCone()
		{
			ConstrainedBone = new();
			ConeAttachmentBone = new();
			ConeTransformLS = new() { Translation = new() { W = 1.000000F }, Rotation = new() { R = 1.000000F }, Scale = new() { X = 1.000000F, Y = 1.000000F, Z = 1.000000F, W = 1.000000F } };
			HalfOfMaxApertureAngle = 45.000000F;
			ProjectionType = Enums.animPendulumProjectionType.ShortestPathRotational;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
