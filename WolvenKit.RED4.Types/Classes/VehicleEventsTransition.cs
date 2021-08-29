using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleEventsTransition : VehicleTransition
	{
		private CBool _isCameraTogglePressed;
		private CFloat _cameraToggleHoldToResetTimeSeconds;

		[Ordinal(1)] 
		[RED("isCameraTogglePressed")] 
		public CBool IsCameraTogglePressed
		{
			get => GetProperty(ref _isCameraTogglePressed);
			set => SetProperty(ref _isCameraTogglePressed, value);
		}

		[Ordinal(2)] 
		[RED("cameraToggleHoldToResetTimeSeconds")] 
		public CFloat CameraToggleHoldToResetTimeSeconds
		{
			get => GetProperty(ref _cameraToggleHoldToResetTimeSeconds);
			set => SetProperty(ref _cameraToggleHoldToResetTimeSeconds, value);
		}
	}
}
