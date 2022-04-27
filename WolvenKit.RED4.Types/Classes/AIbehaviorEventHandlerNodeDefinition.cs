using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorEventHandlerNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(1)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("resolver")] 
		public CHandle<AIbehaviorEventResolverDefinition> Resolver
		{
			get => GetPropertyValue<CHandle<AIbehaviorEventResolverDefinition>>();
			set => SetPropertyValue<CHandle<AIbehaviorEventResolverDefinition>>(value);
		}

		public AIbehaviorEventHandlerNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
