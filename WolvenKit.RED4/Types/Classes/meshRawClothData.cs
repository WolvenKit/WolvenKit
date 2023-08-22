using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshRawClothData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("state")] 
		public physicsclothState State
		{
			get => GetPropertyValue<physicsclothState>();
			set => SetPropertyValue<physicsclothState>(value);
		}

		[Ordinal(1)] 
		[RED("maxDistanceChannel")] 
		public CArray<DataBuffer> MaxDistanceChannel
		{
			get => GetPropertyValue<CArray<DataBuffer>>();
			set => SetPropertyValue<CArray<DataBuffer>>(value);
		}

		[Ordinal(2)] 
		[RED("maxDistanceExtChannel")] 
		public CArray<DataBuffer> MaxDistanceExtChannel
		{
			get => GetPropertyValue<CArray<DataBuffer>>();
			set => SetPropertyValue<CArray<DataBuffer>>(value);
		}

		[Ordinal(3)] 
		[RED("backstopDistanceChannel")] 
		public CArray<DataBuffer> BackstopDistanceChannel
		{
			get => GetPropertyValue<CArray<DataBuffer>>();
			set => SetPropertyValue<CArray<DataBuffer>>(value);
		}

		[Ordinal(4)] 
		[RED("backstopRadiusChannel")] 
		public CArray<DataBuffer> BackstopRadiusChannel
		{
			get => GetPropertyValue<CArray<DataBuffer>>();
			set => SetPropertyValue<CArray<DataBuffer>>(value);
		}

		[Ordinal(5)] 
		[RED("selfCollisionChannel")] 
		public CArray<DataBuffer> SelfCollisionChannel
		{
			get => GetPropertyValue<CArray<DataBuffer>>();
			set => SetPropertyValue<CArray<DataBuffer>>(value);
		}

		public meshRawClothData()
		{
			State = new physicsclothState { VerticalPhaseData = new physicsclothPhaseConfig { Stiffness = 1.000000F, StiffnessMultiplier = 1.000000F, CompressionLimit = 1.000000F, StretchLimit = 1.000000F }, HorizontalPhaseData = new physicsclothPhaseConfig { Stiffness = 1.000000F, StiffnessMultiplier = 1.000000F, CompressionLimit = 1.000000F, StretchLimit = 1.000000F }, BendPhaseData = new physicsclothPhaseConfig { Stiffness = 1.000000F, StiffnessMultiplier = 1.000000F, CompressionLimit = 1.000000F, StretchLimit = 1.000000F }, ShearPhaseData = new physicsclothPhaseConfig { Stiffness = 1.000000F, StiffnessMultiplier = 1.000000F, CompressionLimit = 1.000000F, StretchLimit = 1.000000F }, RuntimeInfo = new physicsclothRuntimeInfo { Translation = new Vector3(), Rotation = new Quaternion { R = 1.000000F }, Gravity = new Vector3 { Z = -9.810000F }, Damping = 0.400000F, Drag = 0.200000F, Inertia = 1.000000F, NumSolverIterations = 2, StiffnessFrequency = 100.000000F, Friction = 1.000000F, TetherStiffness = 1.000000F, TetherScale = 1.000000F, SelfCollisionDistance = 0.010000F, SelfCollisionStiffness = 0.500000F, LiftCoefficient = 0.020000F, DragCoefficient = 0.020000F, GravityScale = 1.000000F, MotionConstraintStiffness = 1.000000F } };
			MaxDistanceChannel = new();
			MaxDistanceExtChannel = new();
			BackstopDistanceChannel = new();
			BackstopRadiusChannel = new();
			SelfCollisionChannel = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
