using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActivatorOperationsTrigger : DeviceOperationsTrigger
	{
		[Ordinal(0)] 
		[RED("triggerData")] 
		public CHandle<ActivatorOperationTriggerData> TriggerData
		{
			get => GetPropertyValue<CHandle<ActivatorOperationTriggerData>>();
			set => SetPropertyValue<CHandle<ActivatorOperationTriggerData>>(value);
		}
	}
}
