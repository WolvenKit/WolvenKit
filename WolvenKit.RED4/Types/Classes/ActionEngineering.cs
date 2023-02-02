
namespace WolvenKit.RED4.Types
{
	public partial class ActionEngineering : ActionSkillCheck
	{
		public ActionEngineering()
		{
			RequesterID = new();
			InteractionChoice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };
			ActionWidgetPackage = new() { DependendActions = new() };
			CanTriggerStim = true;
			SkillCheckName = Enums.EDeviceChallengeSkill.Engineering;
			LocalizedName = "LocKey#22276";
			SkillcheckDescription = new() { AdditionalRequirements = new(), OwnerID = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
