using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsDeviceStartPlayerCameraControlEvent : redEvent
	{
		private wCHandle<gameObject> _playerController;
		private Vector4 _initialRotation;
		private CFloat _minYaw;
		private CFloat _maxYaw;
		private CFloat _minPitch;
		private CFloat _maxPitch;

		[Ordinal(0)] 
		[RED("playerController")] 
		public wCHandle<gameObject> PlayerController
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

		public gameeventsDeviceStartPlayerCameraControlEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
