using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorCommandConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] 
		[RED("commandName")] 
		public CHandle<AIArgumentMapping> CommandName
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("useInheritance")] 
		public CBool UseInheritance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isWaiting")] 
		public CBool IsWaiting
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("isExecuting")] 
		public CBool IsExecuting
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("commandOut")] 
		public CHandle<AIArgumentMapping> CommandOut
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorCommandConditionDefinition()
		{
			IsWaiting = true;
			IsExecuting = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
