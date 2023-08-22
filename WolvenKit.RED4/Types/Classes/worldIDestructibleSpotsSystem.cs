
namespace WolvenKit.RED4.Types
{
	public abstract partial class worldIDestructibleSpotsSystem : gameIGameSystem
	{
		public worldIDestructibleSpotsSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
