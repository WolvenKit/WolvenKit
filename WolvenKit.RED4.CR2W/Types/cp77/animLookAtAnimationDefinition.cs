using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtAnimationDefinition : CVariable
	{
		private CFloat _minTransitionDuration;
		private CFloat _playAnimProbability;
		private CFloat _animDelay;
		private CArray<CName> _animations;

		[Ordinal(0)] 
		[RED("minTransitionDuration")] 
		public CFloat MinTransitionDuration
		{
			get => GetProperty(ref _minTransitionDuration);
			set => SetProperty(ref _minTransitionDuration, value);
		}

		[Ordinal(1)] 
		[RED("playAnimProbability")] 
		public CFloat PlayAnimProbability
		{
			get => GetProperty(ref _playAnimProbability);
			set => SetProperty(ref _playAnimProbability, value);
		}

		[Ordinal(2)] 
		[RED("animDelay")] 
		public CFloat AnimDelay
		{
			get => GetProperty(ref _animDelay);
			set => SetProperty(ref _animDelay, value);
		}

		[Ordinal(3)] 
		[RED("animations")] 
		public CArray<CName> Animations
		{
			get => GetProperty(ref _animations);
			set => SetProperty(ref _animations, value);
		}

		public animLookAtAnimationDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
