
namespace WolvenKit.RED4.Types
{
	public partial class QuestEnableInteraction : ActionBool
	{
		public QuestEnableInteraction()
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
