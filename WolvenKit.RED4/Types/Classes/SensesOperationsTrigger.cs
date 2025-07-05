using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SensesOperationsTrigger : DeviceOperationsTrigger
	{
		[Ordinal(0)] 
		[RED("triggerData")] 
		public CHandle<SensesOperationTriggerData> TriggerData
		{
			get => GetPropertyValue<CHandle<SensesOperationTriggerData>>();
			set => SetPropertyValue<CHandle<SensesOperationTriggerData>>(value);
		}

		public SensesOperationsTrigger()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
