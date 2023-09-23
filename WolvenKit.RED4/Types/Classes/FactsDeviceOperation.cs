using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
