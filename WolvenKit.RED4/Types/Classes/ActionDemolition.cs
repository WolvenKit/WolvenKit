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
			InteractionChoice = new gameinteractionsChoice();
			ActionWidgetPackage = new SActionWidgetPackage();
			CanTriggerStim = true;
			SkillCheckName = Enums.EDeviceChallengeSkill.Athletics;
			LocalizedName = "LocKey#22271";
			SkillcheckDescription = new UIInteractionSkillCheck();
			SlotID = new gamemountingMountingSlotId();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
