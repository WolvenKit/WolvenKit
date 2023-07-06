
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameITransformAnimatorSaveSystem : gameIGameSystem
	{
		public gameITransformAnimatorSaveSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
