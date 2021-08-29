using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnActorRid : RedBaseClass
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
	}
}
