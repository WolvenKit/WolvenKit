using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiPuppetPreviewGameController : gameuiPreviewGameController
	{
		private gameuiPuppetPreviewCameraController _cameraController;

		[Ordinal(7)] 
		[RED("cameraController")] 
		public gameuiPuppetPreviewCameraController CameraController
		{
			get => GetProperty(ref _cameraController);
			set => SetProperty(ref _cameraController, value);
		}
	}
}
