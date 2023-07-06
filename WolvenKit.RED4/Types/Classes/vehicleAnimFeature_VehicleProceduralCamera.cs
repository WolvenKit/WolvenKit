using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleAnimFeature_VehicleProceduralCamera : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("cameraTranslationVS")] 
		public Vector4 CameraTranslationVS
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("cameraOrientationVS")] 
		public Quaternion CameraOrientationVS
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		[Ordinal(2)] 
		[RED("cameraTargetWeight")] 
		public CFloat CameraTargetWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public vehicleAnimFeature_VehicleProceduralCamera()
		{
			CameraTranslationVS = new Vector4();
			CameraOrientationVS = new Quaternion { R = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
