using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorItemVirtualController : inkVirtualCompoundItemController
	{
		private CHandle<VendorInventoryItemData> _data;

		[Ordinal(15)] 
		[RED("data")] 
		public CHandle<VendorInventoryItemData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<VendorInventoryItemData>) CR2WTypeManager.Create("handle:VendorInventoryItemData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public VendorItemVirtualController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
