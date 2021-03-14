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
			get
			{
				if (_confirm == null)
				{
					_confirm = (CBool) CR2WTypeManager.Create("Bool", "confirm", cr2w, this);
				}
				return _confirm;
			}
			set
			{
				if (_confirm == value)
				{
					return;
				}
				_confirm = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("items")] 
		public CArray<wCHandle<gameItemData>> Items
		{
			get
			{
				if (_items == null)
				{
					_items = (CArray<wCHandle<gameItemData>>) CR2WTypeManager.Create("array:whandle:gameItemData", "items", cr2w, this);
				}
				return _items;
			}
			set
			{
				if (_items == value)
				{
					return;
				}
				_items = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("limitedItems")] 
		public CArray<CHandle<VendorJunkSellItem>> LimitedItems
		{
			get
			{
				if (_limitedItems == null)
				{
					_limitedItems = (CArray<CHandle<VendorJunkSellItem>>) CR2WTypeManager.Create("array:handle:VendorJunkSellItem", "limitedItems", cr2w, this);
				}
				return _limitedItems;
			}
			set
			{
				if (_limitedItems == value)
				{
					return;
				}
				_limitedItems = value;
				PropertySet(this);
			}
		}

		public VendorSellJunkPopupCloseData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
