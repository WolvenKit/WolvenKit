using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SensesOperationsTrigger : DeviceOperationsTrigger
	{
		[Ordinal(0)] 
		[RED("triggerData")] 
		public CHandle<SensesOperationTriggerData> TriggerData
		{
			get => GetPropertyValue<CHandle<SensesOperationTriggerData>>();
			set => SetPropertyValue<CHandle<SensesOperationTriggerData>>(value);
		}
	}
}
