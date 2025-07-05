
namespace WolvenKit.RED4.Types
{
	public abstract partial class QuickSlotsDecisions : QuickSlotsTransition
	{
		public QuickSlotsDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
