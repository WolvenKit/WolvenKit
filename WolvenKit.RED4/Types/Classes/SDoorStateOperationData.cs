using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SDoorStateOperationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<EDoorStatus> State
		{
			get => GetPropertyValue<CEnum<EDoorStatus>>();
			set => SetPropertyValue<CEnum<EDoorStatus>>(value);
		}

		[Ordinal(1)] 
		[RED("operation")] 
		public SBaseDeviceOperationData Operation
		{
			get => GetPropertyValue<SBaseDeviceOperationData>();
			set => SetPropertyValue<SBaseDeviceOperationData>(value);
		}

		public SDoorStateOperationData()
		{
			Operation = new SBaseDeviceOperationData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
