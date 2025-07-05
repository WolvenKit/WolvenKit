
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIActionTarget : IScriptable
	{
		public AIActionTarget()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
