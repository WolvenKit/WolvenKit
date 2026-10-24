
namespace WolvenKit.RED4.Types
{
	public partial class E3Hack_QuestPlayAnimationKillNPC : ActionBool
	{
		public E3Hack_QuestPlayAnimationKillNPC()
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
