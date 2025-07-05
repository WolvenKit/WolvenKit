using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorPassiveEventTagConditionDefinition : AIbehaviorPassiveConditionDefinition
	{
		[Ordinal(1)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("deactivateEvents")] 
		public CBool DeactivateEvents
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIbehaviorPassiveEventTagConditionDefinition()
		{
			DeactivateEvents = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
