
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIGameSystem : IScriptable
	{
		public gameIGameSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
