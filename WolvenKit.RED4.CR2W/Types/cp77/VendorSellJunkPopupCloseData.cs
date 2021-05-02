using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorSellJunkPopupCloseData : inkGameNotificationData
	{
		private CBool _confirm;
		private CArray<wCHandle<gameItemData>> _items;
		private CArray<CHandle<VendorJunkSellItem>> _limitedItems;

		[Ordinal(6)] 
		[RED("confirm")] 
		public CBool Confirm
		{
			get => GetProperty(ref _confirm);
			set => SetProperty(ref _confirm, value);
		}

		[Ordinal(7)] 
		[RED("items")] 
		public CArray<wCHandle<gameItemData>> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}

		[Ordinal(8)] 
		[RED("limitedItems")] 
		public CArray<CHandle<VendorJunkSellItem>> LimitedItems
		{
			get => GetProperty(ref _limitedItems);
			set => SetProperty(ref _limitedItems, value);
		}

		public VendorSellJunkPopupCloseData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
