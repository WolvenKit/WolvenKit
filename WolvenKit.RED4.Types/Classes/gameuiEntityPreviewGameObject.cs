using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiEntityPreviewGameObject : gameObject
	{
		[Ordinal(35)] 
		[RED("cameraSettings")] 
		public gameuiEntityPreviewCameraSettings CameraSettings
		{
			get => GetPropertyValue<gameuiEntityPreviewCameraSettings>();
			set => SetPropertyValue<gameuiEntityPreviewCameraSettings>(value);
		}

		public gameuiEntityPreviewGameObject()
		{
			CameraSettings = new() { PanSpeed = 0.500000F, RotationSpeed = new() { Pitch = 1.250000F, Yaw = 1.250000F }, RotationMin = new() { Pitch = -85.000000F, Yaw = -360.000000F }, RotationMax = new() { Pitch = -10.000000F, Yaw = 360.000000F }, RotationDefault = new() { Pitch = -70.000000F, Yaw = -90.000000F }, ZoomSpeed = 0.500000F, ZoomMin = 25.000000F, ZoomMax = 100.000000F, ZoomDefault = 50.000000F };
		}
	}
}
