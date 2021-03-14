using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemsDeviceOperation : DeviceOperationBase
	{
		private CArray<SInventoryOperationData> _items;

		[Ordinal(5)] 
		[RED("items")] 
		public CArray<SInventoryOperationData> Items
		{
			get
			{
				if (_items == null)
				{
					_items = (CArray<SInventoryOperationData>) CR2WTypeManager.Create("array:SInventoryOperationData", "items", cr2w, this);
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

		public ItemsDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
