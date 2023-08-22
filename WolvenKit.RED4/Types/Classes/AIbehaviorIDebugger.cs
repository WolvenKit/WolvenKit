
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIbehaviorIDebugger : ISerializable
	{
		public AIbehaviorIDebugger()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
