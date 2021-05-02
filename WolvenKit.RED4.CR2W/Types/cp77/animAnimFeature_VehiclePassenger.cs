using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_VehiclePassenger : animAnimFeature
	{
		private Vector4 _overallForceMS;
		private CFloat _turnSpeed;
		private CFloat _bankSpeed;
		private CFloat _longitudinalForce;
		private CFloat _transversalForce;
		private CFloat _collisionForceLR;
		private CFloat _collisionForceFB;
		private CFloat _speed;
		private CFloat _inputLR;
		private CFloat _inputFB;
		private CFloat _inputGas;
		private CFloat _inputBreak;
		private CFloat _inputHandBreak;
		private CFloat _vehicleRoll;
		private CFloat _vehiclePitch;
		private CBool _isCar;
		private CBool _inAir;
		private CBool _clutchInUse;
		private CBool _headCollision;

		[Ordinal(0)] 
		[RED("overallForceMS")] 
		public Vector4 OverallForceMS
		{
			get => GetProperty(ref _overallForceMS);
			set => SetProperty(ref _overallForceMS, value);
		}

		[Ordinal(1)] 
		[RED("turnSpeed")] 
		public CFloat TurnSpeed
		{
			get => GetProperty(ref _turnSpeed);
			set => SetProperty(ref _turnSpeed, value);
		}

		[Ordinal(2)] 
		[RED("bankSpeed")] 
		public CFloat BankSpeed
		{
			get => GetProperty(ref _bankSpeed);
			set => SetProperty(ref _bankSpeed, value);
		}

		[Ordinal(3)] 
		[RED("longitudinalForce")] 
		public CFloat LongitudinalForce
		{
			get => GetProperty(ref _longitudinalForce);
			set => SetProperty(ref _longitudinalForce, value);
		}

		[Ordinal(4)] 
		[RED("transversalForce")] 
		public CFloat TransversalForce
		{
			get => GetProperty(ref _transversalForce);
			set => SetProperty(ref _transversalForce, value);
		}

		[Ordinal(5)] 
		[RED("collisionForceLR")] 
		public CFloat CollisionForceLR
		{
			get => GetProperty(ref _collisionForceLR);
			set => SetProperty(ref _collisionForceLR, value);
		}

		[Ordinal(6)] 
		[RED("collisionForceFB")] 
		public CFloat CollisionForceFB
		{
			get => GetProperty(ref _collisionForceFB);
			set => SetProperty(ref _collisionForceFB, value);
		}

		[Ordinal(7)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		[Ordinal(8)] 
		[RED("inputLR")] 
		public CFloat InputLR
		{
			get => GetProperty(ref _inputLR);
			set => SetProperty(ref _inputLR, value);
		}

		[Ordinal(9)] 
		[RED("inputFB")] 
		public CFloat InputFB
		{
			get => GetProperty(ref _inputFB);
			set => SetProperty(ref _inputFB, value);
		}

		[Ordinal(10)] 
		[RED("inputGas")] 
		public CFloat InputGas
		{
			get => GetProperty(ref _inputGas);
			set => SetProperty(ref _inputGas, value);
		}

		[Ordinal(11)] 
		[RED("inputBreak")] 
		public CFloat InputBreak
		{
			get => GetProperty(ref _inputBreak);
			set => SetProperty(ref _inputBreak, value);
		}

		[Ordinal(12)] 
		[RED("inputHandBreak")] 
		public CFloat InputHandBreak
		{
			get => GetProperty(ref _inputHandBreak);
			set => SetProperty(ref _inputHandBreak, value);
		}

		[Ordinal(13)] 
		[RED("vehicleRoll")] 
		public CFloat VehicleRoll
		{
			get => GetProperty(ref _vehicleRoll);
			set => SetProperty(ref _vehicleRoll, value);
		}

		[Ordinal(14)] 
		[RED("vehiclePitch")] 
		public CFloat VehiclePitch
		{
			get => GetProperty(ref _vehiclePitch);
			set => SetProperty(ref _vehiclePitch, value);
		}

		[Ordinal(15)] 
		[RED("isCar")] 
		public CBool IsCar
		{
			get => GetProperty(ref _isCar);
			set => SetProperty(ref _isCar, value);
		}

		[Ordinal(16)] 
		[RED("inAir")] 
		public CBool InAir
		{
			get => GetProperty(ref _inAir);
			set => SetProperty(ref _inAir, value);
		}

		[Ordinal(17)] 
		[RED("clutchInUse")] 
		public CBool ClutchInUse
		{
			get => GetProperty(ref _clutchInUse);
			set => SetProperty(ref _clutchInUse, value);
		}

		[Ordinal(18)] 
		[RED("headCollision")] 
		public CBool HeadCollision
		{
			get => GetProperty(ref _headCollision);
			set => SetProperty(ref _headCollision, value);
		}

		public animAnimFeature_VehiclePassenger(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
