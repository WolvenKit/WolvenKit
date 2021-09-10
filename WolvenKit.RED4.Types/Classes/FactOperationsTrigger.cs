using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FactOperationsTrigger : DeviceOperationsTrigger
	{
		[Ordinal(0)] 
		[RED("triggerData")] 
		public CHandle<FactOperationTriggerData> TriggerData
		{
			get => GetPropertyValue<CHandle<FactOperationTriggerData>>();
			set => SetPropertyValue<CHandle<FactOperationTriggerData>>(value);
		}
	}
}
