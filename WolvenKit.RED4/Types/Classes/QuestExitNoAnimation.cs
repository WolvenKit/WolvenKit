
namespace WolvenKit.RED4.Types
{
	public partial class QuestExitNoAnimation : ActionBool
	{
		public QuestExitNoAnimation()
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
