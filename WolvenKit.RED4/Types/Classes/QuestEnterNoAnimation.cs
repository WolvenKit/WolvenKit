
namespace WolvenKit.RED4.Types
{
	public partial class QuestEnterNoAnimation : ActionBool
	{
		public QuestEnterNoAnimation()
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
