
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIIReactionSystem : gameIGameSystem
	{
		public AIIReactionSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
