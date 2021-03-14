using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SItemTransaction : CVariable
	{
		private gameSItemStack _itemStack;
		private CInt32 _pricePerItem;

		[Ordinal(0)] 
		[RED("itemStack")] 
		public gameSItemStack ItemStack
		{
			get
			{
				if (_itemStack == null)
				{
					_itemStack = (gameSItemStack) CR2WTypeManager.Create("gameSItemStack", "itemStack", cr2w, this);
				}
				return _itemStack;
			}
			set
			{
				if (_itemStack == value)
				{
					return;
				}
				_itemStack = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("pricePerItem")] 
		public CInt32 PricePerItem
		{
			get
			{
				if (_pricePerItem == null)
				{
					_pricePerItem = (CInt32) CR2WTypeManager.Create("Int32", "pricePerItem", cr2w, this);
				}
				return _pricePerItem;
			}
			set
			{
				if (_pricePerItem == value)
				{
					return;
				}
				_pricePerItem = value;
				PropertySet(this);
			}
		}

		public SItemTransaction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
