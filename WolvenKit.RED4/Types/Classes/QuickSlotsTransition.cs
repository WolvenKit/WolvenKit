
namespace WolvenKit.RED4.Types
{
	public abstract partial class QuickSlotsTransition : DefaultTransition
	{
		public QuickSlotsTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
