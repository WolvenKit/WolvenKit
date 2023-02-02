using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ArmsCWInSlotPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("equipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(1)] 
		[RED("slotCheckType")] 
		public CEnum<gamedataCheckType> SlotCheckType
		{
			get => GetPropertyValue<CEnum<gamedataCheckType>>();
			set => SetPropertyValue<CEnum<gamedataCheckType>>(value);
		}

		[Ordinal(2)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetPropertyValue<CEnum<gamedataItemType>>();
			set => SetPropertyValue<CEnum<gamedataItemType>>(value);
		}

		[Ordinal(3)] 
		[RED("itemTag")] 
		public CName ItemTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ArmsCWInSlotPrereq()
		{
			EquipmentArea = Enums.gamedataEquipmentArea.ArmsCW;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
