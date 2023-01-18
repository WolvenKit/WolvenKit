using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorSubtreeDefinition : AIbehaviorNestedTreeDefinition
	{
		[Ordinal(2)] 
		[RED("tree")] 
		public CHandle<AIbehaviorParameterizedBehavior> Tree
		{
			get => GetPropertyValue<CHandle<AIbehaviorParameterizedBehavior>>();
			set => SetPropertyValue<CHandle<AIbehaviorParameterizedBehavior>>(value);
		}

		public AIbehaviorSubtreeDefinition()
		{
			LateInitialization = true;
			InitializeOnEvent = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
