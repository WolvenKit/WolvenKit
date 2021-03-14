using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsclothRuntimeInfo : CVariable
	{
		private Vector3 _translation;
		private Quaternion _rotation;
		private Vector3 _gravity;
		private CFloat _damping;
		private CFloat _drag;
		private CFloat _inertia;
		private CUInt32 _numSolverIterations;
		private CFloat _stiffnessFrequency;
		private CFloat _friction;
		private CFloat _tetherStiffness;
		private CFloat _tetherScale;
		private CFloat _selfCollisionDistance;
		private CFloat _selfCollisionStiffness;
		private CFloat _liftCoefficient;
		private CFloat _dragCoefficient;
		private CFloat _gravityScale;
		private CFloat _motionConstraintStiffness;
		private CBool _enableSelfCollision;

		[Ordinal(0)] 
		[RED("translation")] 
		public Vector3 Translation
		{
			get
			{
				if (_translation == null)
				{
					_translation = (Vector3) CR2WTypeManager.Create("Vector3", "translation", cr2w, this);
				}
				return _translation;
			}
			set
			{
				if (_translation == value)
				{
					return;
				}
				_translation = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("rotation")] 
		public Quaternion Rotation
		{
			get
			{
				if (_rotation == null)
				{
					_rotation = (Quaternion) CR2WTypeManager.Create("Quaternion", "rotation", cr2w, this);
				}
				return _rotation;
			}
			set
			{
				if (_rotation == value)
				{
					return;
				}
				_rotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("gravity")] 
		public Vector3 Gravity
		{
			get
			{
				if (_gravity == null)
				{
					_gravity = (Vector3) CR2WTypeManager.Create("Vector3", "gravity", cr2w, this);
				}
				return _gravity;
			}
			set
			{
				if (_gravity == value)
				{
					return;
				}
				_gravity = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("drag")] 
		public CFloat Drag
		{
			get
			{
				if (_drag == null)
				{
					_drag = (CFloat) CR2WTypeManager.Create("Float", "drag", cr2w, this);
				}
				return _drag;
			}
			set
			{
				if (_drag == value)
				{
					return;
				}
				_drag = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("inertia")] 
		public CFloat Inertia
		{
			get
			{
				if (_inertia == null)
				{
					_inertia = (CFloat) CR2WTypeManager.Create("Float", "inertia", cr2w, this);
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

		[Ordinal(6)] 
		[RED("numSolverIterations")] 
		public CUInt32 NumSolverIterations
		{
			get
			{
				if (_numSolverIterations == null)
				{
					_numSolverIterations = (CUInt32) CR2WTypeManager.Create("Uint32", "numSolverIterations", cr2w, this);
				}
				return _numSolverIterations;
			}
			set
			{
				if (_numSolverIterations == value)
				{
					return;
				}
				_numSolverIterations = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("stiffnessFrequency")] 
		public CFloat StiffnessFrequency
		{
			get
			{
				if (_stiffnessFrequency == null)
				{
					_stiffnessFrequency = (CFloat) CR2WTypeManager.Create("Float", "stiffnessFrequency", cr2w, this);
				}
				return _stiffnessFrequency;
			}
			set
			{
				if (_stiffnessFrequency == value)
				{
					return;
				}
				_stiffnessFrequency = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("friction")] 
		public CFloat Friction
		{
			get
			{
				if (_friction == null)
				{
					_friction = (CFloat) CR2WTypeManager.Create("Float", "friction", cr2w, this);
				}
				return _friction;
			}
			set
			{
				if (_friction == value)
				{
					return;
				}
				_friction = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("tetherStiffness")] 
		public CFloat TetherStiffness
		{
			get
			{
				if (_tetherStiffness == null)
				{
					_tetherStiffness = (CFloat) CR2WTypeManager.Create("Float", "tetherStiffness", cr2w, this);
				}
				return _tetherStiffness;
			}
			set
			{
				if (_tetherStiffness == value)
				{
					return;
				}
				_tetherStiffness = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("tetherScale")] 
		public CFloat TetherScale
		{
			get
			{
				if (_tetherScale == null)
				{
					_tetherScale = (CFloat) CR2WTypeManager.Create("Float", "tetherScale", cr2w, this);
				}
				return _tetherScale;
			}
			set
			{
				if (_tetherScale == value)
				{
					return;
				}
				_tetherScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("selfCollisionDistance")] 
		public CFloat SelfCollisionDistance
		{
			get
			{
				if (_selfCollisionDistance == null)
				{
					_selfCollisionDistance = (CFloat) CR2WTypeManager.Create("Float", "selfCollisionDistance", cr2w, this);
				}
				return _selfCollisionDistance;
			}
			set
			{
				if (_selfCollisionDistance == value)
				{
					return;
				}
				_selfCollisionDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("selfCollisionStiffness")] 
		public CFloat SelfCollisionStiffness
		{
			get
			{
				if (_selfCollisionStiffness == null)
				{
					_selfCollisionStiffness = (CFloat) CR2WTypeManager.Create("Float", "selfCollisionStiffness", cr2w, this);
				}
				return _selfCollisionStiffness;
			}
			set
			{
				if (_selfCollisionStiffness == value)
				{
					return;
				}
				_selfCollisionStiffness = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("liftCoefficient")] 
		public CFloat LiftCoefficient
		{
			get
			{
				if (_liftCoefficient == null)
				{
					_liftCoefficient = (CFloat) CR2WTypeManager.Create("Float", "liftCoefficient", cr2w, this);
				}
				return _liftCoefficient;
			}
			set
			{
				if (_liftCoefficient == value)
				{
					return;
				}
				_liftCoefficient = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("dragCoefficient")] 
		public CFloat DragCoefficient
		{
			get
			{
				if (_dragCoefficient == null)
				{
					_dragCoefficient = (CFloat) CR2WTypeManager.Create("Float", "dragCoefficient", cr2w, this);
				}
				return _dragCoefficient;
			}
			set
			{
				if (_dragCoefficient == value)
				{
					return;
				}
				_dragCoefficient = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("gravityScale")] 
		public CFloat GravityScale
		{
			get
			{
				if (_gravityScale == null)
				{
					_gravityScale = (CFloat) CR2WTypeManager.Create("Float", "gravityScale", cr2w, this);
				}
				return _gravityScale;
			}
			set
			{
				if (_gravityScale == value)
				{
					return;
				}
				_gravityScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("motionConstraintStiffness")] 
		public CFloat MotionConstraintStiffness
		{
			get
			{
				if (_motionConstraintStiffness == null)
				{
					_motionConstraintStiffness = (CFloat) CR2WTypeManager.Create("Float", "motionConstraintStiffness", cr2w, this);
				}
				return _motionConstraintStiffness;
			}
			set
			{
				if (_motionConstraintStiffness == value)
				{
					return;
				}
				_motionConstraintStiffness = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("enableSelfCollision")] 
		public CBool EnableSelfCollision
		{
			get
			{
				if (_enableSelfCollision == null)
				{
					_enableSelfCollision = (CBool) CR2WTypeManager.Create("Bool", "enableSelfCollision", cr2w, this);
				}
				return _enableSelfCollision;
			}
			set
			{
				if (_enableSelfCollision == value)
				{
					return;
				}
				_enableSelfCollision = value;
				PropertySet(this);
			}
		}

		public physicsclothRuntimeInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
