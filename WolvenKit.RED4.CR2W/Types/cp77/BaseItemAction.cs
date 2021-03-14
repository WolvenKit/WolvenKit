using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseItemAction : BaseScriptableAction
	{
		private wCHandle<gameItemData> _itemData;
		private CBool _removeAfterUse;
		private CInt32 _quantity;

		[Ordinal(11)] 
		[RED("itemData")] 
		public wCHandle<gameItemData> ItemData
		{
			get
			{
				if (_itemData == null)
				{
					_itemData = (wCHandle<gameItemData>) CR2WTypeManager.Create("whandle:gameItemData", "itemData", cr2w, this);
				}
				return _itemData;
			}
			set
			{
				if (_itemData == value)
				{
					return;
				}
				_itemData = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("removeAfterUse")] 
		public CBool RemoveAfterUse
		{
			get
			{
				if (_removeAfterUse == null)
				{
					_removeAfterUse = (CBool) CR2WTypeManager.Create("Bool", "removeAfterUse", cr2w, this);
				}
				return _removeAfterUse;
			}
			set
			{
				if (_removeAfterUse == value)
				{
					return;
				}
				_removeAfterUse = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get
			{
				if (_quantity == null)
				{
					_quantity = (CInt32) CR2WTypeManager.Create("Int32", "quantity", cr2w, this);
				}
				return _quantity;
			}
			set
			{
				if (_quantity == value)
				{
					return;
				}
				_quantity = value;
				PropertySet(this);
			}
		}

		public BaseItemAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
