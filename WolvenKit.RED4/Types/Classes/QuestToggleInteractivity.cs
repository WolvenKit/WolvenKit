
namespace WolvenKit.RED4.Types
{
	public partial class QuestToggleInteractivity : ActionBool
	{
		public QuestToggleInteractivity()
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
