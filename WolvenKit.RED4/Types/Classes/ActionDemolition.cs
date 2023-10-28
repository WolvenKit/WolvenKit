using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActionDemolition : ActionSkillCheck
	{
		[Ordinal(45)] 
		[RED("slotID")] 
		public gamemountingMountingSlotId SlotID
		{
			get => GetPropertyValue<gamemountingMountingSlotId>();
			set => SetPropertyValue<gamemountingMountingSlotId>(value);
		}

		public ActionDemolition()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice { CaptionParts = new gameinteractionsChoiceCaption { Parts = new() }, Data = new(), ChoiceMetaData = new gameinteractionsChoiceMetaData { Type = new gameinteractionsChoiceTypeWrapper() }, LookAtDescriptor = new gameinteractionsChoiceLookAtDescriptor { Offset = new Vector3(), OrbId = new gameinteractionsOrbID() } };
			ActionWidgetPackage = new SActionWidgetPackage { DependendActions = new() };
			CanTriggerStim = true;
			SkillCheckName = Enums.EDeviceChallengeSkill.Athletics;
			LocalizedName = "LocKey#22271";
			SkillcheckDescription = new UIInteractionSkillCheck { AdditionalRequirements = new(), OwnerID = new entEntityID() };
			SlotID = new gamemountingMountingSlotId();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
