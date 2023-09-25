using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ToggleComponentsDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] 
		[RED("components")] 
		public CArray<SComponentOperationData> Components
		{
			get => GetPropertyValue<CArray<SComponentOperationData>>();
			set => SetPropertyValue<CArray<SComponentOperationData>>(value);
		}

		public ToggleComponentsDeviceOperation()
		{
			IsEnabled = true;
			ToggleOperations = new();
			Components = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
