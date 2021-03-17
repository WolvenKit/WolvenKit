using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ArmorEquipInventoryItemController : inkButtonDpadSupportedController
	{
		private gameItemID _itemID;
		private CHandle<gameItemData> _itemData;
		private CBool _empty;

		[Ordinal(26)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(27)] 
		[RED("itemData")] 
		public CHandle<gameItemData> ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(28)] 
		[RED("empty")] 
		public CBool Empty
		{
			get => GetProperty(ref _empty);
			set => SetProperty(ref _empty, value);
		}

		public ArmorEquipInventoryItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
