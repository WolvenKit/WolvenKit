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
			get
			{
				if (_constraintSphereRadius == null)
				{
					_constraintSphereRadius = (CFloat) CR2WTypeManager.Create("Float", "constraintSphereRadius", cr2w, this);
				}
				return _constraintSphereRadius;
			}
			set
			{
				if (_constraintSphereRadius == value)
				{
					return;
				}
				_constraintSphereRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("constraintScale1")] 
		public CFloat ConstraintScale1
		{
			get
			{
				if (_constraintScale1 == null)
				{
					_constraintScale1 = (CFloat) CR2WTypeManager.Create("Float", "constraintScale1", cr2w, this);
				}
				return _constraintScale1;
			}
			set
			{
				if (_constraintScale1 == value)
				{
					return;
				}
				_constraintScale1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("constraintScale2")] 
		public CFloat ConstraintScale2
		{
			get
			{
				if (_constraintScale2 == null)
				{
					_constraintScale2 = (CFloat) CR2WTypeManager.Create("Float", "constraintScale2", cr2w, this);
				}
				return _constraintScale2;
			}
			set
			{
				if (_constraintScale2 == value)
				{
					return;
				}
				_constraintScale2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("mass")] 
		public CFloat Mass
		{
			get
			{
				if (_mass == null)
				{
					_mass = (CFloat) CR2WTypeManager.Create("Float", "mass", cr2w, this);
				}
				return _mass;
			}
			set
			{
				if (_mass == value)
				{
					return;
				}
				_mass = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("damping")] 
		public CFloat Damping
		{
			get
			{
				if (_damping == null)
				{
					_damping = (CFloat) CR2WTypeManager.Create("Float", "damping", cr2w, this);
				}
				return _damping;
			}
			set
			{
				if (_damping == value)
				{
					return;
				}
				_damping = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("pullForceFactor")] 
		public CFloat PullForceFactor
		{
			get
			{
				if (_pullForceFactor == null)
				{
					_pullForceFactor = (CFloat) CR2WTypeManager.Create("Float", "pullForceFactor", cr2w, this);
				}
				return _pullForceFactor;
			}
			set
			{
				if (_pullForceFactor == value)
				{
					return;
				}
				_pullForceFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("externalForceWS")] 
		public Vector3 ExternalForceWS
		{
			get
			{
				if (_externalForceWS == null)
				{
					_externalForceWS = (Vector3) CR2WTypeManager.Create("Vector3", "externalForceWS", cr2w, this);
				}
				return _externalForceWS;
			}
			set
			{
				if (_externalForceWS == value)
				{
					return;
				}
				_externalForceWS = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("externalForceWsLink")] 
		public animVectorLink ExternalForceWsLink
		{
			get
			{
				if (_externalForceWsLink == null)
				{
					_externalForceWsLink = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "externalForceWsLink", cr2w, this);
				}
				return _externalForceWsLink;
			}
			set
			{
				if (_externalForceWsLink == value)
				{
					return;
				}
				_externalForceWsLink = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("collisionSphereRadius")] 
		public CFloat CollisionSphereRadius
		{
			get
			{
				if (_collisionSphereRadius == null)
				{
					_collisionSphereRadius = (CFloat) CR2WTypeManager.Create("Float", "collisionSphereRadius", cr2w, this);
				}
				return _collisionSphereRadius;
			}
			set
			{
				if (_collisionSphereRadius == value)
				{
					return;
				}
				_collisionSphereRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("invertedMass")] 
		public CFloat InvertedMass
		{
			get
			{
				if (_invertedMass == null)
				{
					_invertedMass = (CFloat) CR2WTypeManager.Create("Float", "invertedMass", cr2w, this);
				}
				return _invertedMass;
			}
			set
			{
				if (_invertedMass == value)
				{
					return;
				}
				_invertedMass = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("simulationFps")] 
		public CFloat SimulationFps
		{
			get
			{
				if (_simulationFps == null)
				{
					_simulationFps = (CFloat) CR2WTypeManager.Create("Float", "simulationFps", cr2w, this);
				}
				return _simulationFps;
			}
			set
			{
				if (_simulationFps == value)
				{
					return;
				}
				_simulationFps = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("gravityWS")] 
		public CFloat GravityWS
		{
			get
			{
				if (_gravityWS == null)
				{
					_gravityWS = (CFloat) CR2WTypeManager.Create("Float", "gravityWS", cr2w, this);
				}
				return _gravityWS;
			}
			set
			{
				if (_gravityWS == value)
				{
					return;
				}
				_gravityWS = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("pullForceOriginLS")] 
		public Vector3 PullForceOriginLS
		{
			get
			{
				if (_pullForceOriginLS == null)
				{
					_pullForceOriginLS = (Vector3) CR2WTypeManager.Create("Vector3", "pullForceOriginLS", cr2w, this);
				}
				return _pullForceOriginLS;
			}
			set
			{
				if (_pullForceOriginLS == value)
				{
					return;
				}
				_pullForceOriginLS = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("projectionType")] 
		public CEnum<animSpringProjectionType> ProjectionType
		{
			get
			{
				if (_projectionType == null)
				{
					_projectionType = (CEnum<animSpringProjectionType>) CR2WTypeManager.Create("animSpringProjectionType", "projectionType", cr2w, this);
				}
				return _projectionType;
			}
			set
			{
				if (_projectionType == value)
				{
					return;
				}
				_projectionType = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("constraintOrientation")] 
		public Vector2 ConstraintOrientation
		{
			get
			{
				if (_constraintOrientation == null)
				{
					_constraintOrientation = (Vector2) CR2WTypeManager.Create("Vector2", "constraintOrientation", cr2w, this);
				}
				return _constraintOrientation;
			}
			set
			{
				if (_constraintOrientation == value)
				{
					return;
				}
				_constraintOrientation = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("cosOfHalfXAngle")] 
		public CFloat CosOfHalfXAngle
		{
			get
			{
				if (_cosOfHalfXAngle == null)
				{
					_cosOfHalfXAngle = (CFloat) CR2WTypeManager.Create("Float", "cosOfHalfXAngle", cr2w, this);
				}
				return _cosOfHalfXAngle;
			}
			set
			{
				if (_cosOfHalfXAngle == value)
				{
					return;
				}
				_cosOfHalfXAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("cosOfHalfYAngle")] 
		public CFloat CosOfHalfYAngle
		{
			get
			{
				if (_cosOfHalfYAngle == null)
				{
					_cosOfHalfYAngle = (CFloat) CR2WTypeManager.Create("Float", "cosOfHalfYAngle", cr2w, this);
				}
				return _cosOfHalfYAngle;
			}
			set
			{
				if (_cosOfHalfYAngle == value)
				{
					return;
				}
				_cosOfHalfYAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("sinOfHalfXAngle")] 
		public CFloat SinOfHalfXAngle
		{
			get
			{
				if (_sinOfHalfXAngle == null)
				{
					_sinOfHalfXAngle = (CFloat) CR2WTypeManager.Create("Float", "sinOfHalfXAngle", cr2w, this);
				}
				return _sinOfHalfXAngle;
			}
			set
			{
				if (_sinOfHalfXAngle == value)
				{
					return;
				}
				_sinOfHalfXAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("sinOfHalfYAngle")] 
		public CFloat SinOfHalfYAngle
		{
			get
			{
				if (_sinOfHalfYAngle == null)
				{
					_sinOfHalfYAngle = (CFloat) CR2WTypeManager.Create("Float", "sinOfHalfYAngle", cr2w, this);
				}
				return _sinOfHalfYAngle;
			}
			set
			{
				if (_sinOfHalfYAngle == value)
				{
					return;
				}
				_sinOfHalfYAngle = value;
				PropertySet(this);
			}
		}

		public animDangleConstraint_SimulationSpring(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
