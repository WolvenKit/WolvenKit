using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiEntityPreviewGameObject : gameObject
	{
		[Ordinal(36)] 
		[RED("cameraSettings")] 
		public gameuiEntityPreviewCameraSettings CameraSettings
		{
			get => GetPropertyValue<gameuiEntityPreviewCameraSettings>();
			set => SetPropertyValue<gameuiEntityPreviewCameraSettings>(value);
		}

		public gameuiEntityPreviewGameObject()
		{
			CameraSettings = new gameuiEntityPreviewCameraSettings();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
