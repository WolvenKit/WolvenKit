using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CustomActionOperationsTriggers : DeviceOperationsTrigger
	{
		[Ordinal(0)] 
		[RED("triggerData")] 
		public CHandle<CustomActionOperationTriggerData> TriggerData
		{
			get => GetPropertyValue<CHandle<CustomActionOperationTriggerData>>();
			set => SetPropertyValue<CHandle<CustomActionOperationTriggerData>>(value);
		}

		public CustomActionOperationsTriggers()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
