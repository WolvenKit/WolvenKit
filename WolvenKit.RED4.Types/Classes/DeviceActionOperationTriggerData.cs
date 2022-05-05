using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeviceActionOperationTriggerData : DeviceOperationTriggerData
	{
		[Ordinal(1)] 
		[RED("action")] 
		public CHandle<ScriptableDeviceAction> Action
		{
			get => GetPropertyValue<CHandle<ScriptableDeviceAction>>();
			set => SetPropertyValue<CHandle<ScriptableDeviceAction>>(value);
		}

		public DeviceActionOperationTriggerData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
