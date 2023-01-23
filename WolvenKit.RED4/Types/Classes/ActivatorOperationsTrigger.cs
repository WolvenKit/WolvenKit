using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActivatorOperationsTrigger : DeviceOperationsTrigger
	{
		[Ordinal(0)] 
		[RED("triggerData")] 
		public CHandle<ActivatorOperationTriggerData> TriggerData
		{
			get => GetPropertyValue<CHandle<ActivatorOperationTriggerData>>();
			set => SetPropertyValue<CHandle<ActivatorOperationTriggerData>>(value);
		}

		public ActivatorOperationsTrigger()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
