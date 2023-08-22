using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animDangleConstraint_SimulationPendulum : animDangleConstraint_SimulationSingleBone
	{
		[Ordinal(14)] 
		[RED("constraintType")] 
		public CEnum<animPendulumConstraintType> ConstraintType
		{
			get => GetPropertyValue<CEnum<animPendulumConstraintType>>();
			set => SetPropertyValue<CEnum<animPendulumConstraintType>>(value);
		}

		[Ordinal(15)] 
		[RED("halfOfMaxApertureAngle")] 
		public CFloat HalfOfMaxApertureAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("mass")] 
		public CFloat Mass
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("damping")] 
		public CFloat Damping
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("pullForceFactor")] 
		public CFloat PullForceFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("pullForceDirectionLS")] 
		public Vector3 PullForceDirectionLS
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(20)] 
		[RED("externalForceWS")] 
		public Vector3 ExternalForceWS
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(21)] 
		[RED("externalForceWsLink")] 
		public animVectorLink ExternalForceWsLink
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		[Ordinal(22)] 
		[RED("collisionCapsuleRadius")] 
		public CFloat CollisionCapsuleRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(23)] 
		[RED("collisionCapsuleHeightExtent")] 
		public CFloat CollisionCapsuleHeightExtent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(24)] 
		[RED("cosOfHalfMaxApertureAngle")] 
		public CFloat CosOfHalfMaxApertureAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("cosOfHalfOfHalfMaxApertureAngle")] 
		public CFloat CosOfHalfOfHalfMaxApertureAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("sinOfHalfOfHalfMaxApertureAngle")] 
		public CFloat SinOfHalfOfHalfMaxApertureAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(27)] 
		[RED("invertedMass")] 
		public CFloat InvertedMass
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(28)] 
		[RED("simulationFps")] 
		public CFloat SimulationFps
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(29)] 
		[RED("gravityWS")] 
		public CFloat GravityWS
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(30)] 
		[RED("projectionType")] 
		public CEnum<animPendulumProjectionType> ProjectionType
		{
			get => GetPropertyValue<CEnum<animPendulumProjectionType>>();
			set => SetPropertyValue<CEnum<animPendulumProjectionType>>(value);
		}

		[Ordinal(31)] 
		[RED("constraintOrientation")] 
		public Vector3 ConstraintOrientation
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(32)] 
		[RED("cosOfHalfXAngle")] 
		public CFloat CosOfHalfXAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(33)] 
		[RED("cosOfHalfYAngle")] 
		public CFloat CosOfHalfYAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(34)] 
		[RED("cosOfHalfZAngle")] 
		public CFloat CosOfHalfZAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(35)] 
		[RED("sinOfHalfXAngle")] 
		public CFloat SinOfHalfXAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(36)] 
		[RED("sinOfHalfYAngle")] 
		public CFloat SinOfHalfYAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(37)] 
		[RED("sinOfHalfZAngle")] 
		public CFloat SinOfHalfZAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animDangleConstraint_SimulationPendulum()
		{
			CollisionRoundedShapes = new();
			JsonCollisionShapesLoadedSuccessfully = true;
			Alpha = 1.000000F;
			RotateParentToLookAtDangle = true;
			ParentRotationAltersTransformsOfDangleAndItsChildren = true;
			ParentRotationAltersTransformsOfNonDanglesAndItsChildren = true;
			DangleAltersTransformsOfItsChildren = true;
			DangleBone = new animTransformIndex();
			HalfOfMaxApertureAngle = 45.000000F;
			Mass = 1.000000F;
			Damping = 1.000000F;
			PullForceDirectionLS = new Vector3();
			ExternalForceWS = new Vector3();
			ExternalForceWsLink = new animVectorLink();
			CosOfHalfMaxApertureAngle = 0.707107F;
			CosOfHalfOfHalfMaxApertureAngle = 0.923880F;
			SinOfHalfOfHalfMaxApertureAngle = 0.382683F;
			InvertedMass = 1.000000F;
			SimulationFps = 10.000000F;
			GravityWS = 9.810000F;
			ProjectionType = Enums.animPendulumProjectionType.ShortestPathRotational;
			ConstraintOrientation = new Vector3 { X = 90.000000F };
			CosOfHalfXAngle = 0.707107F;
			CosOfHalfYAngle = 1.000000F;
			CosOfHalfZAngle = 1.000000F;
			SinOfHalfXAngle = 0.707107F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
