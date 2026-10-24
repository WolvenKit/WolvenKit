
namespace WolvenKit.RED4.Types
{
	public partial class E3Hack_QuestPlayAnimationWeightLift : ActionBool
	{
		public E3Hack_QuestPlayAnimationWeightLift()
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
