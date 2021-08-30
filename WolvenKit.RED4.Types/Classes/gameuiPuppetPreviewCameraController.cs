using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiPuppetPreviewCameraController : RedBaseClass
	{
		private CArray<gameuiPuppetPreviewCameraSetup> _cameraSetup;
		private CUInt32 _activeSetup;
		private CFloat _transitionDelay;

		[Ordinal(0)] 
		[RED("cameraSetup")] 
		public CArray<gameuiPuppetPreviewCameraSetup> CameraSetup
		{
			get => GetProperty(ref _cameraSetup);
			set => SetProperty(ref _cameraSetup, value);
		}

		[Ordinal(1)] 
		[RED("activeSetup")] 
		public CUInt32 ActiveSetup
		{
			get => GetProperty(ref _activeSetup);
			set => SetProperty(ref _activeSetup, value);
		}

		[Ordinal(2)] 
		[RED("transitionDelay")] 
		public CFloat TransitionDelay
		{
			get => GetProperty(ref _transitionDelay);
			set => SetProperty(ref _transitionDelay, value);
		}

		public gameuiPuppetPreviewCameraController()
		{
			_transitionDelay = 0.500000F;
		}
	}
}
