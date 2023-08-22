
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIbehaviorEventResolverDefinition : ISerializable
	{
		public AIbehaviorEventResolverDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
