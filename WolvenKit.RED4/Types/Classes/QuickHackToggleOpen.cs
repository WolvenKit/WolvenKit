
namespace WolvenKit.RED4.Types
{
	public partial class QuickHackToggleOpen : ActionBool
	{
		public QuickHackToggleOpen()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice();
			ActionWidgetPackage = new SActionWidgetPackage();
			CanTriggerStim = true;
			IsQuickHack = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
