using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class AIbehaviorActionTreeNodeDefinition : AIbehaviorLeafTreeNodeDefinition
	{
		[Ordinal(0)] 
		[RED("command")] 
		public CHandle<AIArgumentMapping> Command
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorActionTreeNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
