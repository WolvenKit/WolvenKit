
namespace WolvenKit.RED4.Types
{
	public partial class ScriptableEnv : gameScriptableService
	{
		public ScriptableEnv()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
