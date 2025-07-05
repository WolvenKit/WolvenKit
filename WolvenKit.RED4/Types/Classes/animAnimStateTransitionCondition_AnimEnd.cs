using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimStateTransitionCondition_AnimEnd : animIAnimStateTransitionCondition
	{
		[Ordinal(0)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimStateTransitionCondition_AnimEnd()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
