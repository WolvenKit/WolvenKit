
namespace WolvenKit.RED4.Types
{
	public partial class OpenWardrobeUI : ActionBool
	{
		public OpenWardrobeUI()
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
