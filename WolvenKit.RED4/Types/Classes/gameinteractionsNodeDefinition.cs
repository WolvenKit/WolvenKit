
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameinteractionsNodeDefinition : IScriptable
	{
		public gameinteractionsNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
