using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinimalLootingListItemData : IScriptable
	{
		private wCHandle<gameItemData> _gameItemData;
		private CString _itemName;
		private CEnum<gamedataItemType> _itemType;
		private CEnum<gamedataEquipmentArea> _equipmentArea;
		private CEnum<gamedataQuality> _quality;
		private CBool _isIconic;
		private CInt32 _quantity;
		private CEnum<gameLootItemType> _lootItemType;
		private CFloat _dpsDiff;

		[Ordinal(0)] 
		[RED("gameItemData")] 
		public wCHandle<gameItemData> GameItemData
		{
			get => GetProperty(ref _gameItemData);
			set => SetProperty(ref _gameItemData, value);
		}

		[Ordinal(1)] 
		[RED("itemName")] 
		public CString ItemName
		{
			get => GetProperty(ref _itemName);
			set => SetProperty(ref _itemName, value);
		}

		[Ordinal(2)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetProperty(ref _itemType);
			set => SetProperty(ref _itemType, value);
		}

		[Ordinal(3)] 
		[RED("equipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get => GetProperty(ref _equipmentArea);
			set => SetProperty(ref _equipmentArea, value);
		}

		[Ordinal(4)] 
		[RED("quality")] 
		public CEnum<gamedataQuality> Quality
		{
			get => GetProperty(ref _quality);
			set => SetProperty(ref _quality, value);
		}

		[Ordinal(5)] 
		[RED("isIconic")] 
		public CBool IsIconic
		{
			get => GetProperty(ref _isIconic);
			set => SetProperty(ref _isIconic, value);
		}

		[Ordinal(6)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetProperty(ref _quantity);
			set => SetProperty(ref _quantity, value);
		}

		[Ordinal(7)] 
		[RED("lootItemType")] 
		public CEnum<gameLootItemType> LootItemType
		{
			get => GetProperty(ref _lootItemType);
			set => SetProperty(ref _lootItemType, value);
		}

		[Ordinal(8)] 
		[RED("dpsDiff")] 
		public CFloat DpsDiff
		{
			get => GetProperty(ref _dpsDiff);
			set => SetProperty(ref _dpsDiff, value);
		}

		public MinimalLootingListItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
