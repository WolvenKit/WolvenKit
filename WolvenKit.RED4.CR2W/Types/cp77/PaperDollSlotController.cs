using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PaperDollSlotController : inkButtonDpadSupportedController
	{
		private CEnum<gamedataEquipmentArea> _equipArea;
		private CInt32 _slotIndex;
		private CArray<CName> _areaTags;
		private gameItemID _itemID;
		private CString _slotName;
		private CHandle<gameItemData> _itemData;
		private CBool _locked;

		[Ordinal(26)] 
		[RED("equipArea")] 
		public CEnum<gamedataEquipmentArea> EquipArea
		{
			get => GetProperty(ref _equipArea);
			set => SetProperty(ref _equipArea, value);
		}

		[Ordinal(27)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get => GetProperty(ref _slotIndex);
			set => SetProperty(ref _slotIndex, value);
		}

		[Ordinal(28)] 
		[RED("areaTags")] 
		public CArray<CName> AreaTags
		{
			get => GetProperty(ref _areaTags);
			set => SetProperty(ref _areaTags, value);
		}

		[Ordinal(29)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(30)] 
		[RED("slotName")] 
		public CString SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(31)] 
		[RED("itemData")] 
		public CHandle<gameItemData> ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(32)] 
		[RED("locked")] 
		public CBool Locked
		{
			get => GetProperty(ref _locked);
			set => SetProperty(ref _locked, value);
		}

		public PaperDollSlotController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
