
namespace WolvenKit.RED4.Types
{
	public partial class gameIScriptableSystem : IScriptable
	{
		public gameIScriptableSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
