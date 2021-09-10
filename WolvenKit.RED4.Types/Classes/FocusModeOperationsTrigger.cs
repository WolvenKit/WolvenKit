using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FocusModeOperationsTrigger : DeviceOperationsTrigger
	{
		[Ordinal(0)] 
		[RED("triggerData")] 
		public CHandle<FocusModeOperationTriggerData> TriggerData
		{
			get => GetPropertyValue<CHandle<FocusModeOperationTriggerData>>();
			set => SetPropertyValue<CHandle<FocusModeOperationTriggerData>>(value);
		}
	}
}
