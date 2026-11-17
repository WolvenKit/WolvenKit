using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animDyngConstraintCone : animIDyngConstraint
	{
		[Ordinal(0)] 
		[RED("constrainedBone")] 
		public animTransformIndex ConstrainedBone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(1)] 
		[RED("coneAttachmentBone")] 
		public animTransformIndex ConeAttachmentBone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(2)] 
		[RED("coneTransformLS")] 
		public QsTransform ConeTransformLS
		{
			get => GetPropertyValue<QsTransform>();
			set => SetPropertyValue<QsTransform>(value);
		}

		[Ordinal(3)] 
		[RED("constraintType")] 
		public CEnum<animPendulumConstraintType> ConstraintType
		{
			get => GetPropertyValue<CEnum<animPendulumConstraintType>>();
			set => SetPropertyValue<CEnum<animPendulumConstraintType>>(value);
		}

		[Ordinal(4)] 
		[RED("halfOfMaxApertureAngle")] 
		public CFloat HalfOfMaxApertureAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("projectionType")] 
		public CEnum<animPendulumProjectionType> ProjectionType
		{
			get => GetPropertyValue<CEnum<animPendulumProjectionType>>();
			set => SetPropertyValue<CEnum<animPendulumProjectionType>>(value);
		}

		[Ordinal(6)] 
		[RED("collisionCapsuleRadius")] 
		public CFloat CollisionCapsuleRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("collisionCapsuleHeightExtent")] 
		public CFloat CollisionCapsuleHeightExtent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animDyngConstraintCone()
		{
			ConstrainedBone = new animTransformIndex();
			ConeAttachmentBone = new animTransformIndex();
			ConeTransformLS = new QsTransform { Translation = new Vector4 { W = 1.000000F } };
			HalfOfMaxApertureAngle = 45.000000F;
			ProjectionType = Enums.animPendulumProjectionType.ShortestPathRotational;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
