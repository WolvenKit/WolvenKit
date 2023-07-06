
namespace WolvenKit.RED4.Types
{
	public abstract partial class ChangeHighLevelStateAbstract : AIbehaviortaskScript
	{
		public ChangeHighLevelStateAbstract()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
