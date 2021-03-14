using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animDangleConstraint_SimulationPendulum : animDangleConstraint_SimulationSingleBone
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
			get
			{
				if (_constraintType == null)
				{
					_constraintType = (CEnum<animPendulumConstraintType>) CR2WTypeManager.Create("animPendulumConstraintType", "constraintType", cr2w, this);
				}
				return _constraintType;
			}
			set
			{
				if (_constraintType == value)
				{
					return;
				}
				_constraintType = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("halfOfMaxApertureAngle")] 
		public CFloat HalfOfMaxApertureAngle
		{
			get
			{
				if (_halfOfMaxApertureAngle == null)
				{
					_halfOfMaxApertureAngle = (CFloat) CR2WTypeManager.Create("Float", "halfOfMaxApertureAngle", cr2w, this);
				}
				return _halfOfMaxApertureAngle;
			}
			set
			{
				if (_halfOfMaxApertureAngle == value)
				{
					return;
				}
				_halfOfMaxApertureAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
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

		[Ordinal(17)] 
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

		[Ordinal(18)] 
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

		[Ordinal(19)] 
		[RED("pullForceDirectionLS")] 
		public Vector3 PullForceDirectionLS
		{
			get
			{
				if (_pullForceDirectionLS == null)
				{
					_pullForceDirectionLS = (Vector3) CR2WTypeManager.Create("Vector3", "pullForceDirectionLS", cr2w, this);
				}
				return _pullForceDirectionLS;
			}
			set
			{
				if (_pullForceDirectionLS == value)
				{
					return;
				}
				_pullForceDirectionLS = value;
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
		[RED("collisionCapsuleRadius")] 
		public CFloat CollisionCapsuleRadius
		{
			get
			{
				if (_collisionCapsuleRadius == null)
				{
					_collisionCapsuleRadius = (CFloat) CR2WTypeManager.Create("Float", "collisionCapsuleRadius", cr2w, this);
				}
				return _collisionCapsuleRadius;
			}
			set
			{
				if (_collisionCapsuleRadius == value)
				{
					return;
				}
				_collisionCapsuleRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("collisionCapsuleHeightExtent")] 
		public CFloat CollisionCapsuleHeightExtent
		{
			get
			{
				if (_collisionCapsuleHeightExtent == null)
				{
					_collisionCapsuleHeightExtent = (CFloat) CR2WTypeManager.Create("Float", "collisionCapsuleHeightExtent", cr2w, this);
				}
				return _collisionCapsuleHeightExtent;
			}
			set
			{
				if (_collisionCapsuleHeightExtent == value)
				{
					return;
				}
				_collisionCapsuleHeightExtent = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("cosOfHalfMaxApertureAngle")] 
		public CFloat CosOfHalfMaxApertureAngle
		{
			get
			{
				if (_cosOfHalfMaxApertureAngle == null)
				{
					_cosOfHalfMaxApertureAngle = (CFloat) CR2WTypeManager.Create("Float", "cosOfHalfMaxApertureAngle", cr2w, this);
				}
				return _cosOfHalfMaxApertureAngle;
			}
			set
			{
				if (_cosOfHalfMaxApertureAngle == value)
				{
					return;
				}
				_cosOfHalfMaxApertureAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("cosOfHalfOfHalfMaxApertureAngle")] 
		public CFloat CosOfHalfOfHalfMaxApertureAngle
		{
			get
			{
				if (_cosOfHalfOfHalfMaxApertureAngle == null)
				{
					_cosOfHalfOfHalfMaxApertureAngle = (CFloat) CR2WTypeManager.Create("Float", "cosOfHalfOfHalfMaxApertureAngle", cr2w, this);
				}
				return _cosOfHalfOfHalfMaxApertureAngle;
			}
			set
			{
				if (_cosOfHalfOfHalfMaxApertureAngle == value)
				{
					return;
				}
				_cosOfHalfOfHalfMaxApertureAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("sinOfHalfOfHalfMaxApertureAngle")] 
		public CFloat SinOfHalfOfHalfMaxApertureAngle
		{
			get
			{
				if (_sinOfHalfOfHalfMaxApertureAngle == null)
				{
					_sinOfHalfOfHalfMaxApertureAngle = (CFloat) CR2WTypeManager.Create("Float", "sinOfHalfOfHalfMaxApertureAngle", cr2w, this);
				}
				return _sinOfHalfOfHalfMaxApertureAngle;
			}
			set
			{
				if (_sinOfHalfOfHalfMaxApertureAngle == value)
				{
					return;
				}
				_sinOfHalfOfHalfMaxApertureAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
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

		[Ordinal(28)] 
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

		[Ordinal(29)] 
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

		[Ordinal(30)] 
		[RED("projectionType")] 
		public CEnum<animPendulumProjectionType> ProjectionType
		{
			get
			{
				if (_projectionType == null)
				{
					_projectionType = (CEnum<animPendulumProjectionType>) CR2WTypeManager.Create("animPendulumProjectionType", "projectionType", cr2w, this);
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

		[Ordinal(31)] 
		[RED("constraintOrientation")] 
		public Vector3 ConstraintOrientation
		{
			get
			{
				if (_constraintOrientation == null)
				{
					_constraintOrientation = (Vector3) CR2WTypeManager.Create("Vector3", "constraintOrientation", cr2w, this);
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

		[Ordinal(32)] 
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

		[Ordinal(33)] 
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

		[Ordinal(34)] 
		[RED("cosOfHalfZAngle")] 
		public CFloat CosOfHalfZAngle
		{
			get
			{
				if (_cosOfHalfZAngle == null)
				{
					_cosOfHalfZAngle = (CFloat) CR2WTypeManager.Create("Float", "cosOfHalfZAngle", cr2w, this);
				}
				return _cosOfHalfZAngle;
			}
			set
			{
				if (_cosOfHalfZAngle == value)
				{
					return;
				}
				_cosOfHalfZAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
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

		[Ordinal(36)] 
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

		[Ordinal(37)] 
		[RED("sinOfHalfZAngle")] 
		public CFloat SinOfHalfZAngle
		{
			get
			{
				if (_sinOfHalfZAngle == null)
				{
					_sinOfHalfZAngle = (CFloat) CR2WTypeManager.Create("Float", "sinOfHalfZAngle", cr2w, this);
				}
				return _sinOfHalfZAngle;
			}
			set
			{
				if (_sinOfHalfZAngle == value)
				{
					return;
				}
				_sinOfHalfZAngle = value;
				PropertySet(this);
			}
		}

		public animDangleConstraint_SimulationPendulum(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
