
namespace WolvenKit.RED4.Types
{
	public abstract partial class AICoreTasks : AIbehaviortaskScript
	{
		public AICoreTasks()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
