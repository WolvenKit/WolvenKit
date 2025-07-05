
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIGenericLookatTask : AILookatTask
	{
		public AIGenericLookatTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
