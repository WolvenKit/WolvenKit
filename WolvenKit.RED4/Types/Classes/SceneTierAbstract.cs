
namespace WolvenKit.RED4.Types
{
	public abstract partial class SceneTierAbstract : HighLevelTransition
	{
		public SceneTierAbstract()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
