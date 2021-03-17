using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animDangleConstraint_SimulationSpring : animDangleConstraint_SimulationSingleBone
	{
		private CFloat _constraintSphereRadius;
		private CFloat _constraintScale1;
		private CFloat _constraintScale2;
		private CFloat _mass;
		private CFloat _damping;
		private CFloat _pullForceFactor;
		private Vector3 _externalForceWS;
		private animVectorLink _externalForceWsLink;
		private CFloat _collisionSphereRadius;
		private CFloat _invertedMass;
		private CFloat _simulationFps;
		private CFloat _gravityWS;
		private Vector3 _pullForceOriginLS;
		private CEnum<animSpringProjectionType> _projectionType;
		private Vector2 _constraintOrientation;
		private CFloat _cosOfHalfXAngle;
		private CFloat _cosOfHalfYAngle;
		private CFloat _sinOfHalfXAngle;
		private CFloat _sinOfHalfYAngle;

		[Ordinal(14)] 
		[RED("constraintSphereRadius")] 
		public CFloat ConstraintSphereRadius
		{
			get => GetProperty(ref _constraintSphereRadius);
			set => SetProperty(ref _constraintSphereRadius, value);
		}

		[Ordinal(15)] 
		[RED("constraintScale1")] 
		public CFloat ConstraintScale1
		{
			get => GetProperty(ref _constraintScale1);
			set => SetProperty(ref _constraintScale1, value);
		}

		[Ordinal(16)] 
		[RED("constraintScale2")] 
		public CFloat ConstraintScale2
		{
			get => GetProperty(ref _constraintScale2);
			set => SetProperty(ref _constraintScale2, value);
		}

		[Ordinal(17)] 
		[RED("mass")] 
		public CFloat Mass
		{
			get => GetProperty(ref _mass);
			set => SetProperty(ref _mass, value);
		}

		[Ordinal(18)] 
		[RED("damping")] 
		public CFloat Damping
		{
			get => GetProperty(ref _damping);
			set => SetProperty(ref _damping, value);
		}

		[Ordinal(19)] 
		[RED("pullForceFactor")] 
		public CFloat PullForceFactor
		{
			get => GetProperty(ref _pullForceFactor);
			set => SetProperty(ref _pullForceFactor, value);
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
		[RED("collisionSphereRadius")] 
		public CFloat CollisionSphereRadius
		{
			get => GetProperty(ref _collisionSphereRadius);
			set => SetProperty(ref _collisionSphereRadius, value);
		}

		[Ordinal(23)] 
		[RED("invertedMass")] 
		public CFloat InvertedMass
		{
			get => GetProperty(ref _invertedMass);
			set => SetProperty(ref _invertedMass, value);
		}

		[Ordinal(24)] 
		[RED("simulationFps")] 
		public CFloat SimulationFps
		{
			get => GetProperty(ref _simulationFps);
			set => SetProperty(ref _simulationFps, value);
		}

		[Ordinal(25)] 
		[RED("gravityWS")] 
		public CFloat GravityWS
		{
			get => GetProperty(ref _gravityWS);
			set => SetProperty(ref _gravityWS, value);
		}

		[Ordinal(26)] 
		[RED("pullForceOriginLS")] 
		public Vector3 PullForceOriginLS
		{
			get => GetProperty(ref _pullForceOriginLS);
			set => SetProperty(ref _pullForceOriginLS, value);
		}

		[Ordinal(27)] 
		[RED("projectionType")] 
		public CEnum<animSpringProjectionType> ProjectionType
		{
			get => GetProperty(ref _projectionType);
			set => SetProperty(ref _projectionType, value);
		}

		[Ordinal(28)] 
		[RED("constraintOrientation")] 
		public Vector2 ConstraintOrientation
		{
			get => GetProperty(ref _constraintOrientation);
			set => SetProperty(ref _constraintOrientation, value);
		}

		[Ordinal(29)] 
		[RED("cosOfHalfXAngle")] 
		public CFloat CosOfHalfXAngle
		{
			get => GetProperty(ref _cosOfHalfXAngle);
			set => SetProperty(ref _cosOfHalfXAngle, value);
		}

		[Ordinal(30)] 
		[RED("cosOfHalfYAngle")] 
		public CFloat CosOfHalfYAngle
		{
			get => GetProperty(ref _cosOfHalfYAngle);
			set => SetProperty(ref _cosOfHalfYAngle, value);
		}

		[Ordinal(31)] 
		[RED("sinOfHalfXAngle")] 
		public CFloat SinOfHalfXAngle
		{
			get => GetProperty(ref _sinOfHalfXAngle);
			set => SetProperty(ref _sinOfHalfXAngle, value);
		}

		[Ordinal(32)] 
		[RED("sinOfHalfYAngle")] 
		public CFloat SinOfHalfYAngle
		{
			get => GetProperty(ref _sinOfHalfYAngle);
			set => SetProperty(ref _sinOfHalfYAngle, value);
		}

		public animDangleConstraint_SimulationSpring(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
