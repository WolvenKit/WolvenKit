
namespace WolvenKit.RED4.Types
{
	public abstract partial class SquadTask : AIbehaviortaskScript
	{
		public SquadTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
