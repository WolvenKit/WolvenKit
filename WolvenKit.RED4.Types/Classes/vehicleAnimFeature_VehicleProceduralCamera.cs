using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleAnimFeature_VehicleProceduralCamera : animAnimFeature
	{
		private Vector4 _cameraTranslationVS;
		private Quaternion _cameraOrientationVS;

		[Ordinal(0)] 
		[RED("cameraTranslationVS")] 
		public Vector4 CameraTranslationVS
		{
			get => GetProperty(ref _cameraTranslationVS);
			set => SetProperty(ref _cameraTranslationVS, value);
		}

		[Ordinal(1)] 
		[RED("cameraOrientationVS")] 
		public Quaternion CameraOrientationVS
		{
			get => GetProperty(ref _cameraOrientationVS);
			set => SetProperty(ref _cameraOrientationVS, value);
		}
	}
}
