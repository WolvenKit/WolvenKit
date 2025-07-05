using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsclothRuntimeInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("translation")] 
		public Vector3 Translation
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(1)] 
		[RED("rotation")] 
		public Quaternion Rotation
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		[Ordinal(2)] 
		[RED("gravity")] 
		public Vector3 Gravity
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(3)] 
		[RED("damping")] 
		public CFloat Damping
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("drag")] 
		public CFloat Drag
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("inertia")] 
		public CFloat Inertia
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("numSolverIterations")] 
		public CUInt32 NumSolverIterations
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(7)] 
		[RED("stiffnessFrequency")] 
		public CFloat StiffnessFrequency
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("friction")] 
		public CFloat Friction
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("tetherStiffness")] 
		public CFloat TetherStiffness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("tetherScale")] 
		public CFloat TetherScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("selfCollisionDistance")] 
		public CFloat SelfCollisionDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("selfCollisionStiffness")] 
		public CFloat SelfCollisionStiffness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("liftCoefficient")] 
		public CFloat LiftCoefficient
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("dragCoefficient")] 
		public CFloat DragCoefficient
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("gravityScale")] 
		public CFloat GravityScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("motionConstraintStiffness")] 
		public CFloat MotionConstraintStiffness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("enableSelfCollision")] 
		public CBool EnableSelfCollision
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public physicsclothRuntimeInfo()
		{
			Translation = new Vector3();
			Rotation = new Quaternion { R = 1.000000F };
			Gravity = new Vector3 { Z = -9.810000F };
			Damping = 0.400000F;
			Drag = 0.200000F;
			Inertia = 1.000000F;
			NumSolverIterations = 2;
			StiffnessFrequency = 100.000000F;
			Friction = 1.000000F;
			TetherStiffness = 1.000000F;
			TetherScale = 1.000000F;
			SelfCollisionDistance = 0.010000F;
			SelfCollisionStiffness = 0.500000F;
			LiftCoefficient = 0.020000F;
			DragCoefficient = 0.020000F;
			GravityScale = 1.000000F;
			MotionConstraintStiffness = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
