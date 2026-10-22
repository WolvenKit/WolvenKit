
namespace WolvenKit.RED4.Types
{
	public partial class DisassembleAction : BaseItemAction
	{
		public DisassembleAction()
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
