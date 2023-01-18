using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimStateTransitionCondition_HasAnimation : animIAnimStateTransitionCondition
	{
		[Ordinal(0)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimStateTransitionCondition_HasAnimation()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
