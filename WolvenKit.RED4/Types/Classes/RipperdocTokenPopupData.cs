using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocTokenPopupData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("cwItemData")] 
		public gameInventoryItemData CwItemData
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		public RipperdocTokenPopupData()
		{
			CwItemData = new() { ID = new(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, Empty = true, IsAvailable = true, PositionInBackpack = 4294967295, IsRequirementMet = true, IsEquippable = true, Requirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirements = new(), Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
