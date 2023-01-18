using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorPassiveSignalConditionDefinition : AIbehaviorPassiveConditionDefinition
	{
		[Ordinal(1)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("deactivateSignal")] 
		public CBool DeactivateSignal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIbehaviorPassiveSignalConditionDefinition()
		{
			DeactivateSignal = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
