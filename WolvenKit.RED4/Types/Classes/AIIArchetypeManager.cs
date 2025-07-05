
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIIArchetypeManager : gameIGameSystem
	{
		public AIIArchetypeManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
