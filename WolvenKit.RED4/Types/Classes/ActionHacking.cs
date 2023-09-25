
namespace WolvenKit.RED4.Types
{
	public partial class ActionHacking : ActionSkillCheck
	{
		public ActionHacking()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice { CaptionParts = new gameinteractionsChoiceCaption { Parts = new() }, Data = new(), ChoiceMetaData = new gameinteractionsChoiceMetaData { Type = new gameinteractionsChoiceTypeWrapper() }, LookAtDescriptor = new gameinteractionsChoiceLookAtDescriptor { Offset = new Vector3(), OrbId = new gameinteractionsOrbID() } };
			ActionWidgetPackage = new SActionWidgetPackage { DependendActions = new() };
			CanTriggerStim = true;
			SkillCheckName = Enums.EDeviceChallengeSkill.Hacking;
			LocalizedName = "LocKey#22278";
			SkillcheckDescription = new UIInteractionSkillCheck { AdditionalRequirements = new(), OwnerID = new entEntityID() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
