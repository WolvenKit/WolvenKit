using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorEntityReuseEventResolverDefinition : AIbehaviorEventResolverDefinition
	{
		[Ordinal(0)] 
		[RED("destination")] 
		public CHandle<AIArgumentMapping> Destination
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(1)] 
		[RED("fastForwardAfterTeleport")] 
		public CHandle<AIArgumentMapping> FastForwardAfterTeleport
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorEntityReuseEventResolverDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
