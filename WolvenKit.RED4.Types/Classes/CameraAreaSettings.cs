using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CameraAreaSettings : IAreaSettings
	{
		private CFloat _cameraNearPlane;
		private CFloat _cameraFarPlane;
		private CBool _automated;
		private CUInt32 _iSO;
		private CFloat _shutterTime;
		private CFloat _fStop;

		[Ordinal(2)] 
		[RED("cameraNearPlane")] 
		public CFloat CameraNearPlane
		{
			get => GetProperty(ref _cameraNearPlane);
			set => SetProperty(ref _cameraNearPlane, value);
		}

		[Ordinal(3)] 
		[RED("cameraFarPlane")] 
		public CFloat CameraFarPlane
		{
			get => GetProperty(ref _cameraFarPlane);
			set => SetProperty(ref _cameraFarPlane, value);
		}

		[Ordinal(4)] 
		[RED("automated")] 
		public CBool Automated
		{
			get => GetProperty(ref _automated);
			set => SetProperty(ref _automated, value);
		}

		[Ordinal(5)] 
		[RED("ISO")] 
		public CUInt32 ISO
		{
			get => GetProperty(ref _iSO);
			set => SetProperty(ref _iSO, value);
		}

		[Ordinal(6)] 
		[RED("shutterTime")] 
		public CFloat ShutterTime
		{
			get => GetProperty(ref _shutterTime);
			set => SetProperty(ref _shutterTime, value);
		}

		[Ordinal(7)] 
		[RED("fStop")] 
		public CFloat FStop
		{
			get => GetProperty(ref _fStop);
			set => SetProperty(ref _fStop, value);
		}

		public CameraAreaSettings()
		{
			_cameraNearPlane = 0.400000F;
			_cameraFarPlane = 8000.000000F;
			_iSO = 100;
			_shutterTime = 125.000000F;
			_fStop = 8.000000F;
		}
	}
}
