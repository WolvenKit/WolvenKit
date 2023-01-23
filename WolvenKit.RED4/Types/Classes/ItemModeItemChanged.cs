using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemModeItemChanged : redEvent
	{
		[Ordinal(0)] 
		[RED("equipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(1)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("hotkey")] 
		public CEnum<gameEHotkey> Hotkey
		{
			get => GetPropertyValue<CEnum<gameEHotkey>>();
			set => SetPropertyValue<CEnum<gameEHotkey>>(value);
		}

		public ItemModeItemChanged()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
