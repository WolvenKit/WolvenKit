
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActionDemolition : ActionSkillCheck
	{

		public ActionDemolition()
		{
			RequesterID = new();
			InteractionChoice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };
			ActionWidgetPackage = new() { DependendActions = new() };
			CanTriggerStim = true;
			SkillCheckName = Enums.EDeviceChallengeSkill.Athletics;
			LocalizedName = "LocKey#22271";
			SkillcheckDescription = new() { AdditionalRequirements = new(), OwnerID = new() };
		}
	}
}
