using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Movement : animAnimFeature
	{
		private Vector4 _movementDirection;
		private CFloat _speed;
		private CFloat _desiredSpeed;
		private CFloat _stabilizedSpeed;
		private CFloat _acceleration;
		private CFloat _timeToChangeLocomotion;
		private CFloat _strafeYaw;
		private CFloat _yawSpeed;
		private CInt32 _locomotionState;

		[Ordinal(0)] 
		[RED("movementDirection")] 
		public Vector4 MovementDirection
		{
			get => GetProperty(ref _movementDirection);
			set => SetProperty(ref _movementDirection, value);
		}

		[Ordinal(1)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		[Ordinal(2)] 
		[RED("desiredSpeed")] 
		public CFloat DesiredSpeed
		{
			get => GetProperty(ref _desiredSpeed);
			set => SetProperty(ref _desiredSpeed, value);
		}

		[Ordinal(3)] 
		[RED("stabilizedSpeed")] 
		public CFloat StabilizedSpeed
		{
			get => GetProperty(ref _stabilizedSpeed);
			set => SetProperty(ref _stabilizedSpeed, value);
		}

		[Ordinal(4)] 
		[RED("acceleration")] 
		public CFloat Acceleration
		{
			get => GetProperty(ref _acceleration);
			set => SetProperty(ref _acceleration, value);
		}

		[Ordinal(5)] 
		[RED("timeToChangeLocomotion")] 
		public CFloat TimeToChangeLocomotion
		{
			get => GetProperty(ref _timeToChangeLocomotion);
			set => SetProperty(ref _timeToChangeLocomotion, value);
		}

		[Ordinal(6)] 
		[RED("strafeYaw")] 
		public CFloat StrafeYaw
		{
			get => GetProperty(ref _strafeYaw);
			set => SetProperty(ref _strafeYaw, value);
		}

		[Ordinal(7)] 
		[RED("yawSpeed")] 
		public CFloat YawSpeed
		{
			get => GetProperty(ref _yawSpeed);
			set => SetProperty(ref _yawSpeed, value);
		}

		[Ordinal(8)] 
		[RED("locomotionState")] 
		public CInt32 LocomotionState
		{
			get => GetProperty(ref _locomotionState);
			set => SetProperty(ref _locomotionState, value);
		}

		public animAnimFeature_Movement(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
