
namespace WolvenKit.RED4.Types
{
	public partial class QuestForceAuthorizationDisabled : ActionBool
	{
		public QuestForceAuthorizationDisabled()
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
