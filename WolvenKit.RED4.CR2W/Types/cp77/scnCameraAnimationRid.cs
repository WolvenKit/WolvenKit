using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnCameraAnimationRid : CVariable
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

		public scnCameraAnimationRid(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
