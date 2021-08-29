using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsDeviceStartPlayerCameraControlEvent : redEvent
	{
		private CWeakHandle<gameObject> _playerController;
		private Vector4 _initialRotation;
		private CFloat _minYaw;
		private CFloat _maxYaw;
		private CFloat _minPitch;
		private CFloat _maxPitch;

		[Ordinal(0)] 
		[RED("playerController")] 
		public CWeakHandle<gameObject> PlayerController
		{
			get => GetProperty(ref _playerController);
			set => SetProperty(ref _playerController, value);
		}

		[Ordinal(1)] 
		[RED("initialRotation")] 
		public Vector4 InitialRotation
		{
			get => GetProperty(ref _initialRotation);
			set => SetProperty(ref _initialRotation, value);
		}

		[Ordinal(2)] 
		[RED("minYaw")] 
		public CFloat MinYaw
		{
			get => GetProperty(ref _minYaw);
			set => SetProperty(ref _minYaw, value);
		}

		[Ordinal(3)] 
		[RED("maxYaw")] 
		public CFloat MaxYaw
		{
			get => GetProperty(ref _maxYaw);
			set => SetProperty(ref _maxYaw, value);
		}

		[Ordinal(4)] 
		[RED("minPitch")] 
		public CFloat MinPitch
		{
			get => GetProperty(ref _minPitch);
			set => SetProperty(ref _minPitch, value);
		}

		[Ordinal(5)] 
		[RED("maxPitch")] 
		public CFloat MaxPitch
		{
			get => GetProperty(ref _maxPitch);
			set => SetProperty(ref _maxPitch, value);
		}
	}
}
