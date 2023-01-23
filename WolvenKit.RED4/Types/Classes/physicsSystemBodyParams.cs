using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsSystemBodyParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("simulationType")] 
		public CEnum<physicsSimulationType> SimulationType
		{
			get => GetPropertyValue<CEnum<physicsSimulationType>>();
			set => SetPropertyValue<CEnum<physicsSimulationType>>(value);
		}

		[Ordinal(1)] 
		[RED("linearDamping")] 
		public CFloat LinearDamping
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("angularDamping")] 
		public CFloat AngularDamping
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("solverIterationsCountPosition")] 
		public CUInt32 SolverIterationsCountPosition
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("solverIterationsCountVelocity")] 
		public CUInt32 SolverIterationsCountVelocity
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(5)] 
		[RED("maxDepenetrationVelocity")] 
		public CFloat MaxDepenetrationVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("maxAngularVelocity")] 
		public CFloat MaxAngularVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("maxContactImpulse")] 
		public CFloat MaxContactImpulse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("mass")] 
		public CFloat Mass
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("inertia")] 
		public Vector3 Inertia
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(10)] 
		[RED("comOffset")] 
		public Transform ComOffset
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		public physicsSystemBodyParams()
		{
			SimulationType = Enums.physicsSimulationType.Dynamic;
			SolverIterationsCountPosition = 4;
			SolverIterationsCountVelocity = 1;
			MaxDepenetrationVelocity = -1.000000F;
			MaxAngularVelocity = -1.000000F;
			MaxContactImpulse = -1.000000F;
			Inertia = new() { X = 1.000000F, Y = 1.000000F, Z = 1.000000F };
			ComOffset = new() { Position = new(), Orientation = new() { R = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
