using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsSystemBodyParams : CVariable
	{
		private CEnum<physicsSimulationType> _simulationType;
		private CFloat _linearDamping;
		private CFloat _angularDamping;
		private CUInt32 _solverIterationsCountPosition;
		private CUInt32 _solverIterationsCountVelocity;
		private CFloat _maxDepenetrationVelocity;
		private CFloat _maxAngularVelocity;
		private CFloat _maxContactImpulse;
		private CFloat _mass;
		private Vector3 _inertia;
		private Transform _comOffset;

		[Ordinal(0)] 
		[RED("simulationType")] 
		public CEnum<physicsSimulationType> SimulationType
		{
			get
			{
				if (_simulationType == null)
				{
					_simulationType = (CEnum<physicsSimulationType>) CR2WTypeManager.Create("physicsSimulationType", "simulationType", cr2w, this);
				}
				return _simulationType;
			}
			set
			{
				if (_simulationType == value)
				{
					return;
				}
				_simulationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("linearDamping")] 
		public CFloat LinearDamping
		{
			get
			{
				if (_linearDamping == null)
				{
					_linearDamping = (CFloat) CR2WTypeManager.Create("Float", "linearDamping", cr2w, this);
				}
				return _linearDamping;
			}
			set
			{
				if (_linearDamping == value)
				{
					return;
				}
				_linearDamping = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("angularDamping")] 
		public CFloat AngularDamping
		{
			get
			{
				if (_angularDamping == null)
				{
					_angularDamping = (CFloat) CR2WTypeManager.Create("Float", "angularDamping", cr2w, this);
				}
				return _angularDamping;
			}
			set
			{
				if (_angularDamping == value)
				{
					return;
				}
				_angularDamping = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("solverIterationsCountPosition")] 
		public CUInt32 SolverIterationsCountPosition
		{
			get
			{
				if (_solverIterationsCountPosition == null)
				{
					_solverIterationsCountPosition = (CUInt32) CR2WTypeManager.Create("Uint32", "solverIterationsCountPosition", cr2w, this);
				}
				return _solverIterationsCountPosition;
			}
			set
			{
				if (_solverIterationsCountPosition == value)
				{
					return;
				}
				_solverIterationsCountPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("solverIterationsCountVelocity")] 
		public CUInt32 SolverIterationsCountVelocity
		{
			get
			{
				if (_solverIterationsCountVelocity == null)
				{
					_solverIterationsCountVelocity = (CUInt32) CR2WTypeManager.Create("Uint32", "solverIterationsCountVelocity", cr2w, this);
				}
				return _solverIterationsCountVelocity;
			}
			set
			{
				if (_solverIterationsCountVelocity == value)
				{
					return;
				}
				_solverIterationsCountVelocity = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("maxDepenetrationVelocity")] 
		public CFloat MaxDepenetrationVelocity
		{
			get
			{
				if (_maxDepenetrationVelocity == null)
				{
					_maxDepenetrationVelocity = (CFloat) CR2WTypeManager.Create("Float", "maxDepenetrationVelocity", cr2w, this);
				}
				return _maxDepenetrationVelocity;
			}
			set
			{
				if (_maxDepenetrationVelocity == value)
				{
					return;
				}
				_maxDepenetrationVelocity = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("maxAngularVelocity")] 
		public CFloat MaxAngularVelocity
		{
			get
			{
				if (_maxAngularVelocity == null)
				{
					_maxAngularVelocity = (CFloat) CR2WTypeManager.Create("Float", "maxAngularVelocity", cr2w, this);
				}
				return _maxAngularVelocity;
			}
			set
			{
				if (_maxAngularVelocity == value)
				{
					return;
				}
				_maxAngularVelocity = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("maxContactImpulse")] 
		public CFloat MaxContactImpulse
		{
			get
			{
				if (_maxContactImpulse == null)
				{
					_maxContactImpulse = (CFloat) CR2WTypeManager.Create("Float", "maxContactImpulse", cr2w, this);
				}
				return _maxContactImpulse;
			}
			set
			{
				if (_maxContactImpulse == value)
				{
					return;
				}
				_maxContactImpulse = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
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

		[Ordinal(9)] 
		[RED("inertia")] 
		public Vector3 Inertia
		{
			get
			{
				if (_inertia == null)
				{
					_inertia = (Vector3) CR2WTypeManager.Create("Vector3", "inertia", cr2w, this);
				}
				return _inertia;
			}
			set
			{
				if (_inertia == value)
				{
					return;
				}
				_inertia = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("comOffset")] 
		public Transform ComOffset
		{
			get
			{
				if (_comOffset == null)
				{
					_comOffset = (Transform) CR2WTypeManager.Create("Transform", "comOffset", cr2w, this);
				}
				return _comOffset;
			}
			set
			{
				if (_comOffset == value)
				{
					return;
				}
				_comOffset = value;
				PropertySet(this);
			}
		}

		public physicsSystemBodyParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
