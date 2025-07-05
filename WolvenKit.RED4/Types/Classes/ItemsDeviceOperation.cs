using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemsDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] 
		[RED("items")] 
		public CArray<SInventoryOperationData> Items
		{
			get => GetPropertyValue<CArray<SInventoryOperationData>>();
			set => SetPropertyValue<CArray<SInventoryOperationData>>(value);
		}

		public ItemsDeviceOperation()
		{
			IsEnabled = true;
			ToggleOperations = new();
			Items = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
