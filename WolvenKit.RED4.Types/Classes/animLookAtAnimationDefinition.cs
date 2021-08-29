using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animLookAtAnimationDefinition : RedBaseClass
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
	}
}
