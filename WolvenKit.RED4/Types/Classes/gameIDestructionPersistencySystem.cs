
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIDestructionPersistencySystem : gameIGameSystem
	{
		public gameIDestructionPersistencySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
