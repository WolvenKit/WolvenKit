
namespace WolvenKit.RED4.Types
{
	public abstract partial class SceneTierAbstractEvents : SceneTierAbstract
	{
		public SceneTierAbstractEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
