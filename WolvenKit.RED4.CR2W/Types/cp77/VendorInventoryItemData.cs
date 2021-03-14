using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorInventoryItemData : WrappedInventoryItemData
	{
		private CBool _isVendorItem;
		private CBool _isEnoughMoney;
		private CBool _isBuybackStack;

		[Ordinal(5)] 
		[RED("IsVendorItem")] 
		public CBool IsVendorItem
		{
			get
			{
				if (_isVendorItem == null)
				{
					_isVendorItem = (CBool) CR2WTypeManager.Create("Bool", "IsVendorItem", cr2w, this);
				}
				return _isVendorItem;
			}
			set
			{
				if (_isVendorItem == value)
				{
					return;
				}
				_isVendorItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("IsEnoughMoney")] 
		public CBool IsEnoughMoney
		{
			get
			{
				if (_isEnoughMoney == null)
				{
					_isEnoughMoney = (CBool) CR2WTypeManager.Create("Bool", "IsEnoughMoney", cr2w, this);
				}
				return _isEnoughMoney;
			}
			set
			{
				if (_isEnoughMoney == value)
				{
					return;
				}
				_isEnoughMoney = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("IsBuybackStack")] 
		public CBool IsBuybackStack
		{
			get
			{
				if (_isBuybackStack == null)
				{
					_isBuybackStack = (CBool) CR2WTypeManager.Create("Bool", "IsBuybackStack", cr2w, this);
				}
				return _isBuybackStack;
			}
			set
			{
				if (_isBuybackStack == value)
				{
					return;
				}
				_isBuybackStack = value;
				PropertySet(this);
			}
		}

		public VendorInventoryItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
