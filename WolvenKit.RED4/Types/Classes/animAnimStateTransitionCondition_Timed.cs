using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimStateTransitionCondition_Timed : animIAnimStateTransitionCondition
	{
		[Ordinal(0)] 
		[RED("timeToFireTransition")] 
		public CFloat TimeToFireTransition
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animAnimStateTransitionCondition_Timed()
		{
			TimeToFireTransition = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
