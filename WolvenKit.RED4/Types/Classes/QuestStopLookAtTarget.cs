
namespace WolvenKit.RED4.Types
{
	public partial class QuestStopLookAtTarget : ActionBool
	{
		public QuestStopLookAtTarget()
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
