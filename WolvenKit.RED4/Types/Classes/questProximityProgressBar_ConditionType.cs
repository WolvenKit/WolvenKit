using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questProximityProgressBar_ConditionType : questIUIConditionType
	{
		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<questProximityProgressBarAction> Action
		{
			get => GetPropertyValue<CEnum<questProximityProgressBarAction>>();
			set => SetPropertyValue<CEnum<questProximityProgressBarAction>>(value);
		}

		public questProximityProgressBar_ConditionType()
		{
			Action = Enums.questProximityProgressBarAction.Completed;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
