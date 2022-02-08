using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitOperationsTrigger : DeviceOperationsTrigger
	{
		[Ordinal(0)] 
		[RED("triggerData")] 
		public CHandle<HitOperationTriggerData> TriggerData
		{
			get => GetPropertyValue<CHandle<HitOperationTriggerData>>();
			set => SetPropertyValue<CHandle<HitOperationTriggerData>>(value);
		}
	}
}
