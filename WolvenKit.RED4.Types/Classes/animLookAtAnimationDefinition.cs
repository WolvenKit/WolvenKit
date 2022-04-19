using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animLookAtAnimationDefinition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("minTransitionDuration")] 
		public CFloat MinTransitionDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("playAnimProbability")] 
		public CFloat PlayAnimProbability
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("animDelay")] 
		public CFloat AnimDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("animations")] 
		public CArray<CName> Animations
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public animLookAtAnimationDefinition()
		{
			MinTransitionDuration = 1.000000F;
			PlayAnimProbability = 1.000000F;
			Animations = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
