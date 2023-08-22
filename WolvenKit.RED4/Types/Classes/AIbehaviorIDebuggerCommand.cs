
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIbehaviorIDebuggerCommand : ISerializable
	{
		public AIbehaviorIDebuggerCommand()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
