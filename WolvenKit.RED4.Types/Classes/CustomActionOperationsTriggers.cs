using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CustomActionOperationsTriggers : DeviceOperationsTrigger
	{
		[Ordinal(0)] 
		[RED("triggerData")] 
		public CHandle<CustomActionOperationTriggerData> TriggerData
		{
			get => GetPropertyValue<CHandle<CustomActionOperationTriggerData>>();
			set => SetPropertyValue<CHandle<CustomActionOperationTriggerData>>(value);
		}
	}
}
