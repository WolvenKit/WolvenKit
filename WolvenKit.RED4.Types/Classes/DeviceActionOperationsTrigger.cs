using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceActionOperationsTrigger : DeviceOperationsTrigger
	{
		[Ordinal(0)] 
		[RED("triggerData")] 
		public CHandle<DeviceActionOperationTriggerData> TriggerData
		{
			get => GetPropertyValue<CHandle<DeviceActionOperationTriggerData>>();
			set => SetPropertyValue<CHandle<DeviceActionOperationTriggerData>>(value);
		}
	}
}
