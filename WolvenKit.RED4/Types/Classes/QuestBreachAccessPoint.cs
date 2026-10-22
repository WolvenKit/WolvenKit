
namespace WolvenKit.RED4.Types
{
	public partial class QuestBreachAccessPoint : ActionBool
	{
		public QuestBreachAccessPoint()
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
