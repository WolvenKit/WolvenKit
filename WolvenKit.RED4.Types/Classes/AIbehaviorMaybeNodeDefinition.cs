using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorMaybeNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(1)] 
		[RED("onChildSuccess")] 
		public CEnum<AIbehaviorMaybeNodeAction> OnChildSuccess
		{
			get => GetPropertyValue<CEnum<AIbehaviorMaybeNodeAction>>();
			set => SetPropertyValue<CEnum<AIbehaviorMaybeNodeAction>>(value);
		}

		[Ordinal(2)] 
		[RED("onChildFailure")] 
		public CEnum<AIbehaviorMaybeNodeAction> OnChildFailure
		{
			get => GetPropertyValue<CEnum<AIbehaviorMaybeNodeAction>>();
			set => SetPropertyValue<CEnum<AIbehaviorMaybeNodeAction>>(value);
		}

		public AIbehaviorMaybeNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
