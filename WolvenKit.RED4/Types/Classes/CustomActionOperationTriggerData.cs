using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CustomActionOperationTriggerData : DeviceOperationTriggerData
	{
		[Ordinal(1)] 
		[RED("actionID")] 
		public CName ActionID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public CustomActionOperationTriggerData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
