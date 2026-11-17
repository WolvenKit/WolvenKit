
namespace WolvenKit.RED4.Types
{
	public partial class ActionHacking : ActionSkillCheck
	{
		public ActionHacking()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice();
			ActionWidgetPackage = new SActionWidgetPackage();
			CanTriggerStim = true;
			SkillCheckName = Enums.EDeviceChallengeSkill.Hacking;
			LocalizedName = "LocKey#22278";
			SkillcheckDescription = new UIInteractionSkillCheck();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
