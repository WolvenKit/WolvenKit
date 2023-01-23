using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorParallelNodeDefinition : AIbehaviorCompositeTreeNodeDefinition
	{
		[Ordinal(1)] 
		[RED("waitFor")] 
		public CEnum<AIbehaviorParallelNodeWaitFor> WaitFor
		{
			get => GetPropertyValue<CEnum<AIbehaviorParallelNodeWaitFor>>();
			set => SetPropertyValue<CEnum<AIbehaviorParallelNodeWaitFor>>(value);
		}

		public AIbehaviorParallelNodeDefinition()
		{
			Children = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
