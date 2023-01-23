using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MinimalLootingListItemData : IScriptable
	{
		[Ordinal(0)] 
		[RED("gameItemData")] 
		public CWeakHandle<gameItemData> GameItemData
		{
			get => GetPropertyValue<CWeakHandle<gameItemData>>();
			set => SetPropertyValue<CWeakHandle<gameItemData>>(value);
		}

		[Ordinal(1)] 
		[RED("itemName")] 
		public CString ItemName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetPropertyValue<CEnum<gamedataItemType>>();
			set => SetPropertyValue<CEnum<gamedataItemType>>(value);
		}

		[Ordinal(3)] 
		[RED("equipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(4)] 
		[RED("quality")] 
		public CEnum<gamedataQuality> Quality
		{
			get => GetPropertyValue<CEnum<gamedataQuality>>();
			set => SetPropertyValue<CEnum<gamedataQuality>>(value);
		}

		[Ordinal(5)] 
		[RED("isIconic")] 
		public CBool IsIconic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("lootItemType")] 
		public CEnum<gameLootItemType> LootItemType
		{
			get => GetPropertyValue<CEnum<gameLootItemType>>();
			set => SetPropertyValue<CEnum<gameLootItemType>>(value);
		}

		[Ordinal(8)] 
		[RED("tweakDBID")] 
		public TweakDBID TweakDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(9)] 
		[RED("dpsDiff")] 
		public CFloat DpsDiff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("armorDiff")] 
		public CFloat ArmorDiff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public MinimalLootingListItemData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
