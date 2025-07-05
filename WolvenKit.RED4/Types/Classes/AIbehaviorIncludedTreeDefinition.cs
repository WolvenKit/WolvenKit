using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorIncludedTreeDefinition : AIbehaviorNestedTreeDefinition
	{
		[Ordinal(2)] 
		[RED("treeReference")] 
		public CHandle<AIArgumentMapping> TreeReference
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorIncludedTreeDefinition()
		{
			LateInitialization = true;
			InitializeOnEvent = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
