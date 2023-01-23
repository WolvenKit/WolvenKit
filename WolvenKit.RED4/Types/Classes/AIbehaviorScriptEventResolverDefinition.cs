using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorScriptEventResolverDefinition : AIbehaviorEventResolverDefinition
	{
		[Ordinal(0)] 
		[RED("script")] 
		public CHandle<AIbehavioreventResolverScript> Script
		{
			get => GetPropertyValue<CHandle<AIbehavioreventResolverScript>>();
			set => SetPropertyValue<CHandle<AIbehavioreventResolverScript>>(value);
		}

		public AIbehaviorScriptEventResolverDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
