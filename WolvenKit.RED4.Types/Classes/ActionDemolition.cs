using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActionDemolition : ActionSkillCheck
	{
		[Ordinal(31)] 
		[RED("slotID")] 
		public gamemountingMountingSlotId SlotID
		{
			get => GetPropertyValue<gamemountingMountingSlotId>();
			set => SetPropertyValue<gamemountingMountingSlotId>(value);
		}

		public ActionDemolition()
		{
			RequesterID = new();
			InteractionChoice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };
			ActionWidgetPackage = new() { DependendActions = new() };
			CanTriggerStim = true;
			SkillCheckName = Enums.EDeviceChallengeSkill.Athletics;
			LocalizedName = "LocKey#22271";
			SkillcheckDescription = new() { AdditionalRequirements = new(), OwnerID = new() };
			SlotID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
