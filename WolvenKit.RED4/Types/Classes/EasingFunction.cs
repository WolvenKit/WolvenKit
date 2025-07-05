using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EasingFunction : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("transitionType")] 
		public CEnum<ETransitionType> TransitionType
		{
			get => GetPropertyValue<CEnum<ETransitionType>>();
			set => SetPropertyValue<CEnum<ETransitionType>>(value);
		}

		[Ordinal(1)] 
		[RED("easingType")] 
		public CEnum<EEasingType> EasingType
		{
			get => GetPropertyValue<CEnum<EEasingType>>();
			set => SetPropertyValue<CEnum<EEasingType>>(value);
		}

		public EasingFunction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
