
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIActionTransactionSystem : IScriptable
	{
		public AIActionTransactionSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
