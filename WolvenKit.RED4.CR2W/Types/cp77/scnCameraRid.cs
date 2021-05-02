using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnCameraRid : CVariable
	{
		private scnRidTag _tag;
		private CArray<scnCameraAnimationRid> _animations;

		[Ordinal(0)] 
		[RED("tag")] 
		public scnRidTag Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		[Ordinal(1)] 
		[RED("animations")] 
		public CArray<scnCameraAnimationRid> Animations
		{
			get => GetProperty(ref _animations);
			set => SetProperty(ref _animations, value);
		}

		public scnCameraRid(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
