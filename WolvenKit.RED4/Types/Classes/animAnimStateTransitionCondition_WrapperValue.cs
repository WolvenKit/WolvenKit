using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimStateTransitionCondition_WrapperValue : animIAnimStateTransitionCondition
	{
		[Ordinal(0)] 
		[RED("wrapperName")] 
		public CName WrapperName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("checkIfWrapperIsSet")] 
		public CBool CheckIfWrapperIsSet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimStateTransitionCondition_WrapperValue()
		{
			CheckIfWrapperIsSet = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
