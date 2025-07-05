
namespace WolvenKit.RED4.Types
{
	public partial class AISquadScriptInterface : IScriptable
	{
		public AISquadScriptInterface()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
