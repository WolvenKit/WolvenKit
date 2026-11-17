
namespace WolvenKit.RED4.Types
{
	public partial class ConsumeAction : BaseItemAction
	{
		public ConsumeAction()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice();
			Quantity = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
