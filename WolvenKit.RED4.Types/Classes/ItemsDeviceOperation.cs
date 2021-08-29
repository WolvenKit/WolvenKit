using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemsDeviceOperation : DeviceOperationBase
	{
		private CArray<SInventoryOperationData> _items;

		[Ordinal(5)] 
		[RED("items")] 
		public CArray<SInventoryOperationData> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}
	}
}
