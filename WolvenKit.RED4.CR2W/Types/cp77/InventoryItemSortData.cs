using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemSortData : CVariable
	{
		private CString _name;
		private CInt32 _quality;
		private CInt32 _price;
		private CFloat _weight;
		private CInt32 _dPS;
		private CInt32 _itemType;
		private CBool _questItem;
		private CBool _newItem;

		[Ordinal(0)] 
		[RED("Name")] 
		public CString Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("Quality")] 
		public CInt32 Quality
		{
			get => GetProperty(ref _quality);
			set => SetProperty(ref _quality, value);
		}

		[Ordinal(2)] 
		[RED("Price")] 
		public CInt32 Price
		{
			get => GetProperty(ref _price);
			set => SetProperty(ref _price, value);
		}

		[Ordinal(3)] 
		[RED("Weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		[Ordinal(4)] 
		[RED("DPS")] 
		public CInt32 DPS
		{
			get => GetProperty(ref _dPS);
			set => SetProperty(ref _dPS, value);
		}

		[Ordinal(5)] 
		[RED("ItemType")] 
		public CInt32 ItemType
		{
			get => GetProperty(ref _itemType);
			set => SetProperty(ref _itemType, value);
		}

		[Ordinal(6)] 
		[RED("QuestItem")] 
		public CBool QuestItem
		{
			get => GetProperty(ref _questItem);
			set => SetProperty(ref _questItem, value);
		}

		[Ordinal(7)] 
		[RED("NewItem")] 
		public CBool NewItem
		{
			get => GetProperty(ref _newItem);
			set => SetProperty(ref _newItem, value);
		}

		public InventoryItemSortData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
