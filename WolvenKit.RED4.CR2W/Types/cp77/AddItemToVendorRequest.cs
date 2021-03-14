using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddItemToVendorRequest : gameScriptableSystemRequest
	{
		private TweakDBID _vendorID;
		private TweakDBID _itemToAddID;
		private CInt32 _quantity;

		[Ordinal(0)] 
		[RED("vendorID")] 
		public TweakDBID VendorID
		{
			get
			{
				if (_vendorID == null)
				{
					_vendorID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "vendorID", cr2w, this);
				}
				return _vendorID;
			}
			set
			{
				if (_vendorID == value)
				{
					return;
				}
				_vendorID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("itemToAddID")] 
		public TweakDBID ItemToAddID
		{
			get
			{
				if (_itemToAddID == null)
				{
					_itemToAddID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "itemToAddID", cr2w, this);
				}
				return _itemToAddID;
			}
			set
			{
				if (_itemToAddID == value)
				{
					return;
				}
				_itemToAddID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		public AddItemToVendorRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
