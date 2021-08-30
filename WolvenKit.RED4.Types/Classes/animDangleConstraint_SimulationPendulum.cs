using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animDangleConstraint_SimulationPendulum : animDangleConstraint_SimulationSingleBone
	{
		private CEnum<animPendulumConstraintType> _constraintType;
		private CFloat _halfOfMaxApertureAngle;
		private CFloat _mass;
		private CFloat _damping;
		private CFloat _pullForceFactor;
		private Vector3 _pullForceDirectionLS;
		private Vector3 _externalForceWS;
		private animVectorLink _externalForceWsLink;
		private CFloat _collisionCapsuleRadius;
		private CFloat _collisionCapsuleHeightExtent;
		private CFloat _cosOfHalfMaxApertureAngle;
		private CFloat _cosOfHalfOfHalfMaxApertureAngle;
		private CFloat _sinOfHalfOfHalfMaxApertureAngle;
		private CFloat _invertedMass;
		private CFloat _simulationFps;
		private CFloat _gravityWS;
		private CEnum<animPendulumProjectionType> _projectionType;
		private Vector3 _constraintOrientation;
		private CFloat _cosOfHalfXAngle;
		private CFloat _cosOfHalfYAngle;
		private CFloat _cosOfHalfZAngle;
		private CFloat _sinOfHalfXAngle;
		private CFloat _sinOfHalfYAngle;
		private CFloat _sinOfHalfZAngle;

		[Ordinal(14)] 
		[RED("constraintType")] 
		public CEnum<animPendulumConstraintType> ConstraintType
		{
			get => GetProperty(ref _constraintType);
			set => SetProperty(ref _constraintType, value);
		}

		[Ordinal(15)] 
		[RED("halfOfMaxApertureAngle")] 
		public CFloat HalfOfMaxApertureAngle
		{
			get => GetProperty(ref _halfOfMaxApertureAngle);
			set => SetProperty(ref _halfOfMaxApertureAngle, value);
		}

		[Ordinal(16)] 
		[RED("mass")] 
		public CFloat Mass
		{
			get => GetProperty(ref _mass);
			set => SetProperty(ref _mass, value);
		}

		[Ordinal(17)] 
		[RED("damping")] 
		public CFloat Damping
		{
			get => GetProperty(ref _damping);
			set => SetProperty(ref _damping, value);
		}

		[Ordinal(18)] 
		[RED("pullForceFactor")] 
		public CFloat PullForceFactor
		{
			get => GetProperty(ref _pullForceFactor);
			set => SetProperty(ref _pullForceFactor, value);
		}

		[Ordinal(19)] 
		[RED("pullForceDirectionLS")] 
		public Vector3 PullForceDirectionLS
		{
			get => GetProperty(ref _pullForceDirectionLS);
			set => SetProperty(ref _pullForceDirectionLS, value);
		}

		[Ordinal(20)] 
		[RED("externalForceWS")] 
		public Vector3 ExternalForceWS
		{
			get => GetProperty(ref _externalForceWS);
			set => SetProperty(ref _externalForceWS, value);
		}

		[Ordinal(21)] 
		[RED("externalForceWsLink")] 
		public animVectorLink ExternalForceWsLink
		{
			get => GetProperty(ref _externalForceWsLink);
			set => SetProperty(ref _externalForceWsLink, value);
		}

		[Ordinal(22)] 
		[RED("collisionCapsuleRadius")] 
		public CFloat CollisionCapsuleRadius
		{
			get => GetProperty(ref _collisionCapsuleRadius);
			set => SetProperty(ref _collisionCapsuleRadius, value);
		}

		[Ordinal(23)] 
		[RED("collisionCapsuleHeightExtent")] 
		public CFloat CollisionCapsuleHeightExtent
		{
			get => GetProperty(ref _collisionCapsuleHeightExtent);
			set => SetProperty(ref _collisionCapsuleHeightExtent, value);
		}

		[Ordinal(24)] 
		[RED("cosOfHalfMaxApertureAngle")] 
		public CFloat CosOfHalfMaxApertureAngle
		{
			get => GetProperty(ref _cosOfHalfMaxApertureAngle);
			set => SetProperty(ref _cosOfHalfMaxApertureAngle, value);
		}

		[Ordinal(25)] 
		[RED("cosOfHalfOfHalfMaxApertureAngle")] 
		public CFloat CosOfHalfOfHalfMaxApertureAngle
		{
			get => GetProperty(ref _cosOfHalfOfHalfMaxApertureAngle);
			set => SetProperty(ref _cosOfHalfOfHalfMaxApertureAngle, value);
		}

		[Ordinal(26)] 
		[RED("sinOfHalfOfHalfMaxApertureAngle")] 
		public CFloat SinOfHalfOfHalfMaxApertureAngle
		{
			get => GetProperty(ref _sinOfHalfOfHalfMaxApertureAngle);
			set => SetProperty(ref _sinOfHalfOfHalfMaxApertureAngle, value);
		}

		[Ordinal(27)] 
		[RED("invertedMass")] 
		public CFloat InvertedMass
		{
			get => GetProperty(ref _invertedMass);
			set => SetProperty(ref _invertedMass, value);
		}

		[Ordinal(28)] 
		[RED("simulationFps")] 
		public CFloat SimulationFps
		{
			get => GetProperty(ref _simulationFps);
			set => SetProperty(ref _simulationFps, value);
		}

		[Ordinal(29)] 
		[RED("gravityWS")] 
		public CFloat GravityWS
		{
			get => GetProperty(ref _gravityWS);
			set => SetProperty(ref _gravityWS, value);
		}

		[Ordinal(30)] 
		[RED("projectionType")] 
		public CEnum<animPendulumProjectionType> ProjectionType
		{
			get => GetProperty(ref _projectionType);
			set => SetProperty(ref _projectionType, value);
		}

		[Ordinal(31)] 
		[RED("constraintOrientation")] 
		public Vector3 ConstraintOrientation
		{
			get => GetProperty(ref _constraintOrientation);
			set => SetProperty(ref _constraintOrientation, value);
		}

		[Ordinal(32)] 
		[RED("cosOfHalfXAngle")] 
		public CFloat CosOfHalfXAngle
		{
			get => GetProperty(ref _cosOfHalfXAngle);
			set => SetProperty(ref _cosOfHalfXAngle, value);
		}

		[Ordinal(33)] 
		[RED("cosOfHalfYAngle")] 
		public CFloat CosOfHalfYAngle
		{
			get => GetProperty(ref _cosOfHalfYAngle);
			set => SetProperty(ref _cosOfHalfYAngle, value);
		}

		[Ordinal(34)] 
		[RED("cosOfHalfZAngle")] 
		public CFloat CosOfHalfZAngle
		{
			get => GetProperty(ref _cosOfHalfZAngle);
			set => SetProperty(ref _cosOfHalfZAngle, value);
		}

		[Ordinal(35)] 
		[RED("sinOfHalfXAngle")] 
		public CFloat SinOfHalfXAngle
		{
			get => GetProperty(ref _sinOfHalfXAngle);
			set => SetProperty(ref _sinOfHalfXAngle, value);
		}

		[Ordinal(36)] 
		[RED("sinOfHalfYAngle")] 
		public CFloat SinOfHalfYAngle
		{
			get => GetProperty(ref _sinOfHalfYAngle);
			set => SetProperty(ref _sinOfHalfYAngle, value);
		}

		[Ordinal(37)] 
		[RED("sinOfHalfZAngle")] 
		public CFloat SinOfHalfZAngle
		{
			get => GetProperty(ref _sinOfHalfZAngle);
			set => SetProperty(ref _sinOfHalfZAngle, value);
		}

		public animDangleConstraint_SimulationPendulum()
		{
			_halfOfMaxApertureAngle = 45.000000F;
			_mass = 1.000000F;
			_damping = 1.000000F;
			_cosOfHalfMaxApertureAngle = 0.707107F;
			_cosOfHalfOfHalfMaxApertureAngle = 0.923880F;
			_sinOfHalfOfHalfMaxApertureAngle = 0.382683F;
			_invertedMass = 1.000000F;
			_simulationFps = 10.000000F;
			_gravityWS = 9.810000F;
			_projectionType = new() { Value = Enums.animPendulumProjectionType.ShortestPathRotational };
			_cosOfHalfXAngle = 0.707107F;
			_cosOfHalfYAngle = 1.000000F;
			_cosOfHalfZAngle = 1.000000F;
			_sinOfHalfXAngle = 0.707107F;
		}
	}
}
