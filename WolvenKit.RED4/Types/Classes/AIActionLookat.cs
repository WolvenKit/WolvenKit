
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIActionLookat : IScriptable
	{
		public AIActionLookat()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
