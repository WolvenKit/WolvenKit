using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnActorRid : CVariable
	{
		private scnRidTag _tag;
		private CArray<scnAnimationRid> _animations;
		private CArray<scnAnimationRid> _facialAnimations;
		private CArray<scnAnimationRid> _cyberwareAnimations;

		[Ordinal(0)] 
		[RED("tag")] 
		public scnRidTag Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		[Ordinal(1)] 
		[RED("animations")] 
		public CArray<scnAnimationRid> Animations
		{
			get => GetProperty(ref _animations);
			set => SetProperty(ref _animations, value);
		}

		[Ordinal(2)] 
		[RED("facialAnimations")] 
		public CArray<scnAnimationRid> FacialAnimations
		{
			get => GetProperty(ref _facialAnimations);
			set => SetProperty(ref _facialAnimations, value);
		}

		[Ordinal(3)] 
		[RED("cyberwareAnimations")] 
		public CArray<scnAnimationRid> CyberwareAnimations
		{
			get => GetProperty(ref _cyberwareAnimations);
			set => SetProperty(ref _cyberwareAnimations, value);
		}

		public scnActorRid(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
