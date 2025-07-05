using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorCommandHandlerNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(1)] 
		[RED("commandName")] 
		public CName CommandName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("useInheritance")] 
		public CBool UseInheritance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("contexts")] 
		public CArray<CEnum<AICommandContextsType>> Contexts
		{
			get => GetPropertyValue<CArray<CEnum<AICommandContextsType>>>();
			set => SetPropertyValue<CArray<CEnum<AICommandContextsType>>>(value);
		}

		[Ordinal(4)] 
		[RED("commandOut")] 
		public CHandle<AIArgumentMapping> CommandOut
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(5)] 
		[RED("runningSignal")] 
		public CName RunningSignal
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("waitForCommand")] 
		public CBool WaitForCommand
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("retryIfCommandEnqueued")] 
		public CBool RetryIfCommandEnqueued
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("resultIfNoCommand")] 
		public CEnum<AIbehaviorCompletionStatus> ResultIfNoCommand
		{
			get => GetPropertyValue<CEnum<AIbehaviorCompletionStatus>>();
			set => SetPropertyValue<CEnum<AIbehaviorCompletionStatus>>(value);
		}

		[Ordinal(9)] 
		[RED("resultIfChildFailed")] 
		public CEnum<AIbehaviorCompletionStatus> ResultIfChildFailed
		{
			get => GetPropertyValue<CEnum<AIbehaviorCompletionStatus>>();
			set => SetPropertyValue<CEnum<AIbehaviorCompletionStatus>>(value);
		}

		public AIbehaviorCommandHandlerNodeDefinition()
		{
			Contexts = new();
			ResultIfNoCommand = Enums.AIbehaviorCompletionStatus.SUCCESS;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
