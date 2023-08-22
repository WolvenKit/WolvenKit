
namespace WolvenKit.RED4.Types
{
	public abstract partial class QuickSlotsHoldDecisions : QuickSlotsDecisions
	{
		public QuickSlotsHoldDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
