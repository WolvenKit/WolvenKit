using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorSignalConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] 
		[RED("signalName")] 
		public CName SignalName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("mode")] 
		public CEnum<AIbehaviorSignalConditionModes> Mode
		{
			get => GetPropertyValue<CEnum<AIbehaviorSignalConditionModes>>();
			set => SetPropertyValue<CEnum<AIbehaviorSignalConditionModes>>(value);
		}

		[Ordinal(3)] 
		[RED("tagSignal")] 
		public CBool TagSignal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIbehaviorSignalConditionDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
