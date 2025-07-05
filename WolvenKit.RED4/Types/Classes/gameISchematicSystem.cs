
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameISchematicSystem : gameIGameSystem
	{
		public gameISchematicSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
