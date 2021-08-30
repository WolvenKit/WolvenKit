using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsSystemBodyParams : RedBaseClass
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
			get => GetProperty(ref _simulationType);
			set => SetProperty(ref _simulationType, value);
		}

		[Ordinal(1)] 
		[RED("linearDamping")] 
		public CFloat LinearDamping
		{
			get => GetProperty(ref _linearDamping);
			set => SetProperty(ref _linearDamping, value);
		}

		[Ordinal(2)] 
		[RED("angularDamping")] 
		public CFloat AngularDamping
		{
			get => GetProperty(ref _angularDamping);
			set => SetProperty(ref _angularDamping, value);
		}

		[Ordinal(3)] 
		[RED("solverIterationsCountPosition")] 
		public CUInt32 SolverIterationsCountPosition
		{
			get => GetProperty(ref _solverIterationsCountPosition);
			set => SetProperty(ref _solverIterationsCountPosition, value);
		}

		[Ordinal(4)] 
		[RED("solverIterationsCountVelocity")] 
		public CUInt32 SolverIterationsCountVelocity
		{
			get => GetProperty(ref _solverIterationsCountVelocity);
			set => SetProperty(ref _solverIterationsCountVelocity, value);
		}

		[Ordinal(5)] 
		[RED("maxDepenetrationVelocity")] 
		public CFloat MaxDepenetrationVelocity
		{
			get => GetProperty(ref _maxDepenetrationVelocity);
			set => SetProperty(ref _maxDepenetrationVelocity, value);
		}

		[Ordinal(6)] 
		[RED("maxAngularVelocity")] 
		public CFloat MaxAngularVelocity
		{
			get => GetProperty(ref _maxAngularVelocity);
			set => SetProperty(ref _maxAngularVelocity, value);
		}

		[Ordinal(7)] 
		[RED("maxContactImpulse")] 
		public CFloat MaxContactImpulse
		{
			get => GetProperty(ref _maxContactImpulse);
			set => SetProperty(ref _maxContactImpulse, value);
		}

		[Ordinal(8)] 
		[RED("mass")] 
		public CFloat Mass
		{
			get => GetProperty(ref _mass);
			set => SetProperty(ref _mass, value);
		}

		[Ordinal(9)] 
		[RED("inertia")] 
		public Vector3 Inertia
		{
			get => GetProperty(ref _inertia);
			set => SetProperty(ref _inertia, value);
		}

		[Ordinal(10)] 
		[RED("comOffset")] 
		public Transform ComOffset
		{
			get => GetProperty(ref _comOffset);
			set => SetProperty(ref _comOffset, value);
		}

		public physicsSystemBodyParams()
		{
			_simulationType = new() { Value = Enums.physicsSimulationType.Dynamic };
			_solverIterationsCountPosition = 4;
			_solverIterationsCountVelocity = 1;
			_maxDepenetrationVelocity = -1.000000F;
			_maxAngularVelocity = -1.000000F;
			_maxContactImpulse = -1.000000F;
		}
	}
}
