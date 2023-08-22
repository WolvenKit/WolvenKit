using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animDangleConstraint_SimulationSpring : animDangleConstraint_SimulationSingleBone
	{
		[Ordinal(14)] 
		[RED("constraintSphereRadius")] 
		public CFloat ConstraintSphereRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("constraintScale1")] 
		public CFloat ConstraintScale1
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("constraintScale2")] 
		public CFloat ConstraintScale2
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("mass")] 
		public CFloat Mass
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("damping")] 
		public CFloat Damping
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("pullForceFactor")] 
		public CFloat PullForceFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
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
		[RED("collisionSphereRadius")] 
		public CFloat CollisionSphereRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(23)] 
		[RED("invertedMass")] 
		public CFloat InvertedMass
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(24)] 
		[RED("simulationFps")] 
		public CFloat SimulationFps
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("gravityWS")] 
		public CFloat GravityWS
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("pullForceOriginLS")] 
		public Vector3 PullForceOriginLS
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(27)] 
		[RED("projectionType")] 
		public CEnum<animSpringProjectionType> ProjectionType
		{
			get => GetPropertyValue<CEnum<animSpringProjectionType>>();
			set => SetPropertyValue<CEnum<animSpringProjectionType>>(value);
		}

		[Ordinal(28)] 
		[RED("constraintOrientation")] 
		public Vector2 ConstraintOrientation
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(29)] 
		[RED("cosOfHalfXAngle")] 
		public CFloat CosOfHalfXAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(30)] 
		[RED("cosOfHalfYAngle")] 
		public CFloat CosOfHalfYAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(31)] 
		[RED("sinOfHalfXAngle")] 
		public CFloat SinOfHalfXAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(32)] 
		[RED("sinOfHalfYAngle")] 
		public CFloat SinOfHalfYAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animDangleConstraint_SimulationSpring()
		{
			CollisionRoundedShapes = new();
			JsonCollisionShapesLoadedSuccessfully = true;
			Alpha = 1.000000F;
			RotateParentToLookAtDangle = true;
			ParentRotationAltersTransformsOfDangleAndItsChildren = true;
			ParentRotationAltersTransformsOfNonDanglesAndItsChildren = true;
			DangleAltersTransformsOfItsChildren = true;
			DangleBone = new animTransformIndex();
			ConstraintSphereRadius = 0.500000F;
			ConstraintScale1 = 1.000000F;
			ConstraintScale2 = 1.000000F;
			Mass = 1.000000F;
			Damping = 1.000000F;
			ExternalForceWS = new Vector3();
			ExternalForceWsLink = new animVectorLink();
			InvertedMass = 1.000000F;
			SimulationFps = 10.000000F;
			GravityWS = 9.810000F;
			PullForceOriginLS = new Vector3();
			ProjectionType = Enums.animSpringProjectionType.ShortestPath;
			ConstraintOrientation = new Vector2 { Y = 90.000000F };
			CosOfHalfXAngle = 1.000000F;
			CosOfHalfYAngle = 0.707107F;
			SinOfHalfYAngle = 0.707107F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
