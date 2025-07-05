
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIEvents : IScriptable
	{
		public AIEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
