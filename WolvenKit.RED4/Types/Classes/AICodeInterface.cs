
namespace WolvenKit.RED4.Types
{
	public abstract partial class AICodeInterface : IScriptable
	{
		public AICodeInterface()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
