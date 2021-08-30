using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_SensorDevice : animAnimFeature
	{
		private CBool _isCeiling;
		private CBool _isInitialized;
		private CBool _isTurnedOn;
		private CBool _isDestroyed;
		private CBool _wasHit;
		private CInt32 _state;
		private CInt32 _wakeState;
		private CBool _isControlled;
		private CFloat _overrideRootRotation;
		private CFloat _pitchAngle;
		private CFloat _maxRotationAngle;
		private CFloat _rotationSpeed;
		private Vector4 _currentRotation;

		[Ordinal(0)] 
		[RED("isCeiling")] 
		public CBool IsCeiling
		{
			get => GetProperty(ref _isCeiling);
			set => SetProperty(ref _isCeiling, value);
		}

		[Ordinal(1)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetProperty(ref _isInitialized);
			set => SetProperty(ref _isInitialized, value);
		}

		[Ordinal(2)] 
		[RED("isTurnedOn")] 
		public CBool IsTurnedOn
		{
			get => GetProperty(ref _isTurnedOn);
			set => SetProperty(ref _isTurnedOn, value);
		}

		[Ordinal(3)] 
		[RED("isDestroyed")] 
		public CBool IsDestroyed
		{
			get => GetProperty(ref _isDestroyed);
			set => SetProperty(ref _isDestroyed, value);
		}

		[Ordinal(4)] 
		[RED("wasHit")] 
		public CBool WasHit
		{
			get => GetProperty(ref _wasHit);
			set => SetProperty(ref _wasHit, value);
		}

		[Ordinal(5)] 
		[RED("state")] 
		public CInt32 State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(6)] 
		[RED("wakeState")] 
		public CInt32 WakeState
		{
			get => GetProperty(ref _wakeState);
			set => SetProperty(ref _wakeState, value);
		}

		[Ordinal(7)] 
		[RED("isControlled")] 
		public CBool IsControlled
		{
			get => GetProperty(ref _isControlled);
			set => SetProperty(ref _isControlled, value);
		}

		[Ordinal(8)] 
		[RED("overrideRootRotation")] 
		public CFloat OverrideRootRotation
		{
			get => GetProperty(ref _overrideRootRotation);
			set => SetProperty(ref _overrideRootRotation, value);
		}

		[Ordinal(9)] 
		[RED("pitchAngle")] 
		public CFloat PitchAngle
		{
			get => GetProperty(ref _pitchAngle);
			set => SetProperty(ref _pitchAngle, value);
		}

		[Ordinal(10)] 
		[RED("maxRotationAngle")] 
		public CFloat MaxRotationAngle
		{
			get => GetProperty(ref _maxRotationAngle);
			set => SetProperty(ref _maxRotationAngle, value);
		}

		[Ordinal(11)] 
		[RED("rotationSpeed")] 
		public CFloat RotationSpeed
		{
			get => GetProperty(ref _rotationSpeed);
			set => SetProperty(ref _rotationSpeed, value);
		}

		[Ordinal(12)] 
		[RED("currentRotation")] 
		public Vector4 CurrentRotation
		{
			get => GetProperty(ref _currentRotation);
			set => SetProperty(ref _currentRotation, value);
		}

		public AnimFeature_SensorDevice()
		{
			_isInitialized = true;
		}
	}
}
