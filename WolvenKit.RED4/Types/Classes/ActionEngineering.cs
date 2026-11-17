
namespace WolvenKit.RED4.Types
{
	public partial class ActionEngineering : ActionSkillCheck
	{
		public ActionEngineering()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice();
			ActionWidgetPackage = new SActionWidgetPackage();
			CanTriggerStim = true;
			SkillCheckName = Enums.EDeviceChallengeSkill.Engineering;
			LocalizedName = "LocKey#22276";
			SkillcheckDescription = new UIInteractionSkillCheck();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
