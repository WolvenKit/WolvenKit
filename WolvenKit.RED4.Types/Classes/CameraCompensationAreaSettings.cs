using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CameraCompensationAreaSettings : RedBaseClass
	{
		private CBool _automated;
		private CUInt32 _iSO;
		private CFloat _shutterTime;
		private CFloat _fStop;

		[Ordinal(0)] 
		[RED("automated")] 
		public CBool Automated
		{
			get => GetProperty(ref _automated);
			set => SetProperty(ref _automated, value);
		}

		[Ordinal(1)] 
		[RED("ISO")] 
		public CUInt32 ISO
		{
			get => GetProperty(ref _iSO);
			set => SetProperty(ref _iSO, value);
		}

		[Ordinal(2)] 
		[RED("shutterTime")] 
		public CFloat ShutterTime
		{
			get => GetProperty(ref _shutterTime);
			set => SetProperty(ref _shutterTime, value);
		}

		[Ordinal(3)] 
		[RED("fStop")] 
		public CFloat FStop
		{
			get => GetProperty(ref _fStop);
			set => SetProperty(ref _fStop, value);
		}

		public CameraCompensationAreaSettings()
		{
			_iSO = 100;
			_shutterTime = 125.000000F;
			_fStop = 8.000000F;
		}
	}
}
