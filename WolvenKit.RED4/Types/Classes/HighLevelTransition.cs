
namespace WolvenKit.RED4.Types
{
	public abstract partial class HighLevelTransition : DefaultTransition
	{
		public HighLevelTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
