using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsclothState : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("verticalPhaseData")] 
		public physicsclothPhaseConfig VerticalPhaseData
		{
			get => GetPropertyValue<physicsclothPhaseConfig>();
			set => SetPropertyValue<physicsclothPhaseConfig>(value);
		}

		[Ordinal(1)] 
		[RED("horizontalPhaseData")] 
		public physicsclothPhaseConfig HorizontalPhaseData
		{
			get => GetPropertyValue<physicsclothPhaseConfig>();
			set => SetPropertyValue<physicsclothPhaseConfig>(value);
		}

		[Ordinal(2)] 
		[RED("bendPhaseData")] 
		public physicsclothPhaseConfig BendPhaseData
		{
			get => GetPropertyValue<physicsclothPhaseConfig>();
			set => SetPropertyValue<physicsclothPhaseConfig>(value);
		}

		[Ordinal(3)] 
		[RED("shearPhaseData")] 
		public physicsclothPhaseConfig ShearPhaseData
		{
			get => GetPropertyValue<physicsclothPhaseConfig>();
			set => SetPropertyValue<physicsclothPhaseConfig>(value);
		}

		[Ordinal(4)] 
		[RED("runtimeInfo")] 
		public physicsclothRuntimeInfo RuntimeInfo
		{
			get => GetPropertyValue<physicsclothRuntimeInfo>();
			set => SetPropertyValue<physicsclothRuntimeInfo>(value);
		}

		public physicsclothState()
		{
			VerticalPhaseData = new() { Stiffness = 1.000000F, StiffnessMultiplier = 1.000000F, CompressionLimit = 1.000000F, StretchLimit = 1.000000F };
			HorizontalPhaseData = new() { Stiffness = 1.000000F, StiffnessMultiplier = 1.000000F, CompressionLimit = 1.000000F, StretchLimit = 1.000000F };
			BendPhaseData = new() { Stiffness = 1.000000F, StiffnessMultiplier = 1.000000F, CompressionLimit = 1.000000F, StretchLimit = 1.000000F };
			ShearPhaseData = new() { Stiffness = 1.000000F, StiffnessMultiplier = 1.000000F, CompressionLimit = 1.000000F, StretchLimit = 1.000000F };
			RuntimeInfo = new() { Translation = new(), Rotation = new() { R = 1.000000F }, Gravity = new() { Z = -9.810000F }, Damping = 0.400000F, Drag = 0.200000F, Inertia = 1.000000F, NumSolverIterations = 2, StiffnessFrequency = 100.000000F, Friction = 1.000000F, TetherStiffness = 1.000000F, TetherScale = 1.000000F, SelfCollisionDistance = 0.010000F, SelfCollisionStiffness = 0.500000F, LiftCoefficient = 0.020000F, DragCoefficient = 0.020000F, GravityScale = 1.000000F, MotionConstraintStiffness = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
