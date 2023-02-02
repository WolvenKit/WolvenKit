using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animHasAnimationCondition : animIStaticCondition
	{
		[Ordinal(0)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animHasAnimationCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
