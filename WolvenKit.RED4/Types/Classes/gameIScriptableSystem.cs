
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIScriptableSystem : IScriptable
	{
		public gameIScriptableSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
