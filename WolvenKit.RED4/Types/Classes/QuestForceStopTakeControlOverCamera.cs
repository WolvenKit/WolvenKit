
namespace WolvenKit.RED4.Types
{
	public partial class QuestForceStopTakeControlOverCamera : ActionBool
	{
		public QuestForceStopTakeControlOverCamera()
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
