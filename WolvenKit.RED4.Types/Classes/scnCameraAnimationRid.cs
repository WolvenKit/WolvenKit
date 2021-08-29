using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnCameraAnimationRid : RedBaseClass
	{
		private scnRidTag _tag;
		private CHandle<animIAnimationBuffer> _animation;
		private scnCameraAnimationLOD _cameraAnimationLOD;

		[Ordinal(0)] 
		[RED("tag")] 
		public scnRidTag Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		[Ordinal(1)] 
		[RED("animation")] 
		public CHandle<animIAnimationBuffer> Animation
		{
			get => GetProperty(ref _animation);
			set => SetProperty(ref _animation, value);
		}

		[Ordinal(2)] 
		[RED("cameraAnimationLOD")] 
		public scnCameraAnimationLOD CameraAnimationLOD
		{
			get => GetProperty(ref _cameraAnimationLOD);
			set => SetProperty(ref _cameraAnimationLOD, value);
		}
	}
}
