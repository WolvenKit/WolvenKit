
namespace WolvenKit.RED4.Types
{
	public partial class QuestForceJuryrigTrapArmed : ActionBool
	{
		public QuestForceJuryrigTrapArmed()
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
