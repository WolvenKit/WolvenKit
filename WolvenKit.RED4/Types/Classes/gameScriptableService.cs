
namespace WolvenKit.RED4.Types
{
	public partial class gameScriptableService : IScriptable
	{
		public gameScriptableService()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
