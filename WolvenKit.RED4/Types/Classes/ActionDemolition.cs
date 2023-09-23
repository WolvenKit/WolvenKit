using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActionDemolition : ActionSkillCheck
	{
		[Ordinal(44)] 
		[RED("slotID")] 
		public gamemountingMountingSlotId SlotID
		{
			get => GetPropertyValue<gamemountingMountingSlotId>();
			set => SetPropertyValue<gamemountingMountingSlotId>(value);
		}

		public ActionDemolition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
