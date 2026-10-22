
namespace WolvenKit.RED4.Types
{
	public partial class QuestForceTakeControlOverCamera : ActionBool
	{
		public QuestForceTakeControlOverCamera()
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
