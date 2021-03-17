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
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}

		public ItemsDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
