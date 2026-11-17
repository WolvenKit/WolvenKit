
namespace WolvenKit.RED4.Types
{
	public partial class BeginArcadeMinigameUI : ActionBool
	{
		public BeginArcadeMinigameUI()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice();
			ActionWidgetPackage = new SActionWidgetPackage();
			Duration = 3.967000F;
			CanTriggerStim = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
