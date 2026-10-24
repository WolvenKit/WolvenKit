using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SCustomActionOperationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("actionID")] 
		public CName ActionID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("operation")] 
		public SBaseDeviceOperationData Operation
		{
			get => GetPropertyValue<SBaseDeviceOperationData>();
			set => SetPropertyValue<SBaseDeviceOperationData>(value);
		}

		public SCustomActionOperationData()
		{
			Operation = new SBaseDeviceOperationData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
