using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ProgramEntry : IScriptable
	{
		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(1)] 
		[RED("equippedItem")] 
		public CWeakHandle<gamedataItem_Record> EquippedItem
		{
			get => GetPropertyValue<CWeakHandle<gamedataItem_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataItem_Record>>(value);
		}

		[Ordinal(2)] 
		[RED("abilities")] 
		public CArray<gameInventoryItemAbility> Abilities
		{
			get => GetPropertyValue<CArray<gameInventoryItemAbility>>();
			set => SetPropertyValue<CArray<gameInventoryItemAbility>>(value);
		}

		public ProgramEntry()
		{
			ItemID = new gameItemID();
			Abilities = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
