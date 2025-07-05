using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIInventoryItemModAttachment : UIInventoryItemMod
	{
		[Ordinal(0)] 
		[RED("IsEmpty")] 
		public CBool IsEmpty
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("SlotName")] 
		public CString SlotName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("Quality")] 
		public CEnum<gamedataQuality> Quality
		{
			get => GetPropertyValue<CEnum<gamedataQuality>>();
			set => SetPropertyValue<CEnum<gamedataQuality>>(value);
		}

		[Ordinal(3)] 
		[RED("AbilitiesSize")] 
		public CInt32 AbilitiesSize
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("Abilities")] 
		public CArray<gameInventoryItemAbility> Abilities
		{
			get => GetPropertyValue<CArray<gameInventoryItemAbility>>();
			set => SetPropertyValue<CArray<gameInventoryItemAbility>>(value);
		}

		public UIInventoryItemModAttachment()
		{
			Abilities = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
