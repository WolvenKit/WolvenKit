
namespace WolvenKit.RED4.Types
{
	public abstract partial class StackChangeHighLevelStateAbstract : AIbehaviortaskStackScript
	{
		public StackChangeHighLevelStateAbstract()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
