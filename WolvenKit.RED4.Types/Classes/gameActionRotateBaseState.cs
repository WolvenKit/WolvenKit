using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameActionRotateBaseState : gameActionReplicatedState
	{
		private CFloat _angleOffset;
		private CFloat _angleTolerance;
		private CBool _keepUpdatingTarget;
		private CBool _useRotationTime;
		private CFloat _rotationSpeed;
		private CFloat _rotationTime;

		[Ordinal(5)] 
		[RED("angleOffset")] 
		public CFloat AngleOffset
		{
			get => GetProperty(ref _angleOffset);
			set => SetProperty(ref _angleOffset, value);
		}

		[Ordinal(6)] 
		[RED("angleTolerance")] 
		public CFloat AngleTolerance
		{
			get => GetProperty(ref _angleTolerance);
			set => SetProperty(ref _angleTolerance, value);
		}

		[Ordinal(7)] 
		[RED("keepUpdatingTarget")] 
		public CBool KeepUpdatingTarget
		{
			get => GetProperty(ref _keepUpdatingTarget);
			set => SetProperty(ref _keepUpdatingTarget, value);
		}

		[Ordinal(8)] 
		[RED("useRotationTime")] 
		public CBool UseRotationTime
		{
			get => GetProperty(ref _useRotationTime);
			set => SetProperty(ref _useRotationTime, value);
		}

		[Ordinal(9)] 
		[RED("rotationSpeed")] 
		public CFloat RotationSpeed
		{
			get => GetProperty(ref _rotationSpeed);
			set => SetProperty(ref _rotationSpeed, value);
		}

		[Ordinal(10)] 
		[RED("rotationTime")] 
		public CFloat RotationTime
		{
			get => GetProperty(ref _rotationTime);
			set => SetProperty(ref _rotationTime, value);
		}

		public gameActionRotateBaseState()
		{
			_rotationTime = -1.000000F;
		}
	}
}
