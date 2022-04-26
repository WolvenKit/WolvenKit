using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InteractionAreaOperationsTrigger : DeviceOperationsTrigger
	{
		[Ordinal(0)] 
		[RED("triggerData")] 
		public CHandle<InteractionAreaOperationTriggerData> TriggerData
		{
			get => GetPropertyValue<CHandle<InteractionAreaOperationTriggerData>>();
			set => SetPropertyValue<CHandle<InteractionAreaOperationTriggerData>>(value);
		}

		public InteractionAreaOperationsTrigger()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
