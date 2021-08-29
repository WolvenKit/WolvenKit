using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiEntityPreviewGameObject : gameObject
	{
		private gameuiEntityPreviewCameraSettings _cameraSettings;

		[Ordinal(40)] 
		[RED("cameraSettings")] 
		public gameuiEntityPreviewCameraSettings CameraSettings
		{
			get => GetProperty(ref _cameraSettings);
			set => SetProperty(ref _cameraSettings, value);
		}
	}
}
