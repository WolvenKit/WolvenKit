
namespace WolvenKit.RED4.Types
{
	public partial class SpiderbotDistractDevice : ActionBool
	{
		public SpiderbotDistractDevice()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice();
			ActionWidgetPackage = new SActionWidgetPackage();
			CanTriggerStim = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
