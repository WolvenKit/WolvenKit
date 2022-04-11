using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FactsDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] 
		[RED("facts")] 
		public CArray<SFactOperationData> Facts
		{
			get => GetPropertyValue<CArray<SFactOperationData>>();
			set => SetPropertyValue<CArray<SFactOperationData>>(value);
		}

		public FactsDeviceOperation()
		{
			IsEnabled = true;
			ToggleOperations = new();
			Facts = new();
		}
	}
}
