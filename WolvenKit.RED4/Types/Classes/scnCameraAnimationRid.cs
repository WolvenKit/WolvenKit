using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnCameraAnimationRid : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("tag")] 
		public scnRidTag Tag
		{
			get => GetPropertyValue<scnRidTag>();
			set => SetPropertyValue<scnRidTag>(value);
		}

		[Ordinal(1)] 
		[RED("animation")] 
		public CHandle<animIAnimationBuffer> Animation
		{
			get => GetPropertyValue<CHandle<animIAnimationBuffer>>();
			set => SetPropertyValue<CHandle<animIAnimationBuffer>>(value);
		}

		[Ordinal(2)] 
		[RED("cameraAnimationLOD")] 
		public scnCameraAnimationLOD CameraAnimationLOD
		{
			get => GetPropertyValue<scnCameraAnimationLOD>();
			set => SetPropertyValue<scnCameraAnimationLOD>(value);
		}

		public scnCameraAnimationRid()
		{
			Tag = new scnRidTag { SerialNumber = new scnRidSerialNumber { SerialNumber = uint.MaxValue } };
			CameraAnimationLOD = new scnCameraAnimationLOD { Trajectory = new(0), Tracks = new(0) };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
