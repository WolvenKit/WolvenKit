using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorResource : CResource
	{
		[Ordinal(1)] 
		[RED("root")] 
		public CHandle<AIbehaviorTreeNodeDefinition> Root
		{
			get => GetPropertyValue<CHandle<AIbehaviorTreeNodeDefinition>>();
			set => SetPropertyValue<CHandle<AIbehaviorTreeNodeDefinition>>(value);
		}

		[Ordinal(2)] 
		[RED("arguments")] 
		public AITreeArgumentsDefinition Arguments
		{
			get => GetPropertyValue<AITreeArgumentsDefinition>();
			set => SetPropertyValue<AITreeArgumentsDefinition>(value);
		}

		[Ordinal(3)] 
		[RED("delegate")] 
		public CHandle<AIbehaviorBehaviorDelegate> Delegate
		{
			get => GetPropertyValue<CHandle<AIbehaviorBehaviorDelegate>>();
			set => SetPropertyValue<CHandle<AIbehaviorBehaviorDelegate>>(value);
		}

		[Ordinal(4)] 
		[RED("initializationEvents")] 
		public CArray<CName> InitializationEvents
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public AIbehaviorResource()
		{
			Arguments = new AITreeArgumentsDefinition { Args = new() };
			InitializationEvents = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
