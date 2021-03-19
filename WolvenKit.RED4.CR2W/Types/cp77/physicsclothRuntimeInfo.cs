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
			get => GetProperty(ref _translation);
			set => SetProperty(ref _translation, value);
		}

		[Ordinal(1)] 
		[RED("rotation")] 
		public Quaternion Rotation
		{
			get => GetProperty(ref _rotation);
			set => SetProperty(ref _rotation, value);
		}

		[Ordinal(2)] 
		[RED("gravity")] 
		public Vector3 Gravity
		{
			get => GetProperty(ref _gravity);
			set => SetProperty(ref _gravity, value);
		}

		[Ordinal(3)] 
		[RED("damping")] 
		public CFloat Damping
		{
			get => GetProperty(ref _damping);
			set => SetProperty(ref _damping, value);
		}

		[Ordinal(4)] 
		[RED("drag")] 
		public CFloat Drag
		{
			get => GetProperty(ref _drag);
			set => SetProperty(ref _drag, value);
		}

		[Ordinal(5)] 
		[RED("inertia")] 
		public CFloat Inertia
		{
			get => GetProperty(ref _inertia);
			set => SetProperty(ref _inertia, value);
		}

		[Ordinal(6)] 
		[RED("numSolverIterations")] 
		public CUInt32 NumSolverIterations
		{
			get => GetProperty(ref _numSolverIterations);
			set => SetProperty(ref _numSolverIterations, value);
		}

		[Ordinal(7)] 
		[RED("stiffnessFrequency")] 
		public CFloat StiffnessFrequency
		{
			get => GetProperty(ref _stiffnessFrequency);
			set => SetProperty(ref _stiffnessFrequency, value);
		}

		[Ordinal(8)] 
		[RED("friction")] 
		public CFloat Friction
		{
			get => GetProperty(ref _friction);
			set => SetProperty(ref _friction, value);
		}

		[Ordinal(9)] 
		[RED("tetherStiffness")] 
		public CFloat TetherStiffness
		{
			get => GetProperty(ref _tetherStiffness);
			set => SetProperty(ref _tetherStiffness, value);
		}

		[Ordinal(10)] 
		[RED("tetherScale")] 
		public CFloat TetherScale
		{
			get => GetProperty(ref _tetherScale);
			set => SetProperty(ref _tetherScale, value);
		}

		[Ordinal(11)] 
		[RED("selfCollisionDistance")] 
		public CFloat SelfCollisionDistance
		{
			get => GetProperty(ref _selfCollisionDistance);
			set => SetProperty(ref _selfCollisionDistance, value);
		}

		[Ordinal(12)] 
		[RED("selfCollisionStiffness")] 
		public CFloat SelfCollisionStiffness
		{
			get => GetProperty(ref _selfCollisionStiffness);
			set => SetProperty(ref _selfCollisionStiffness, value);
		}

		[Ordinal(13)] 
		[RED("liftCoefficient")] 
		public CFloat LiftCoefficient
		{
			get => GetProperty(ref _liftCoefficient);
			set => SetProperty(ref _liftCoefficient, value);
		}

		[Ordinal(14)] 
		[RED("dragCoefficient")] 
		public CFloat DragCoefficient
		{
			get => GetProperty(ref _dragCoefficient);
			set => SetProperty(ref _dragCoefficient, value);
		}

		[Ordinal(15)] 
		[RED("gravityScale")] 
		public CFloat GravityScale
		{
			get => GetProperty(ref _gravityScale);
			set => SetProperty(ref _gravityScale, value);
		}

		[Ordinal(16)] 
		[RED("motionConstraintStiffness")] 
		public CFloat MotionConstraintStiffness
		{
			get => GetProperty(ref _motionConstraintStiffness);
			set => SetProperty(ref _motionConstraintStiffness, value);
		}

		[Ordinal(17)] 
		[RED("enableSelfCollision")] 
		public CBool EnableSelfCollision
		{
			get => GetProperty(ref _enableSelfCollision);
			set => SetProperty(ref _enableSelfCollision, value);
		}

		public physicsclothRuntimeInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
