
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIbehaviorBehaviorComponentDefinition : ISerializable
	{
		public AIbehaviorBehaviorComponentDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
