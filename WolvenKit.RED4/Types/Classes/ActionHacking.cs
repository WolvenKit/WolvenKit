
namespace WolvenKit.RED4.Types
{
	public partial class ActionHacking : ActionSkillCheck
	{
		public ActionHacking()
		{
			RequesterID = new();
			InteractionChoice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };
			ActionWidgetPackage = new() { DependendActions = new() };
			CanTriggerStim = true;
			SkillCheckName = Enums.EDeviceChallengeSkill.Hacking;
			LocalizedName = "LocKey#22278";
			SkillcheckDescription = new() { AdditionalRequirements = new(), OwnerID = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
