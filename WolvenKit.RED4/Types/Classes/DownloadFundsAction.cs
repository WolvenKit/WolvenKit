
namespace WolvenKit.RED4.Types
{
	public partial class DownloadFundsAction : BaseItemAction
	{
		public DownloadFundsAction()
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
