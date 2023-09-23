using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GenericDevice : InteractiveDevice
	{
		[Ordinal(98)] 
		[RED("offMeshConnectionComponent")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionComponent
		{
			get => GetPropertyValue<CHandle<AIOffMeshConnectionComponent>>();
			set => SetPropertyValue<CHandle<AIOffMeshConnectionComponent>>(value);
		}

		[Ordinal(99)] 
		[RED("currentSpiderbotAction")] 
		public CHandle<CustomDeviceAction> CurrentSpiderbotAction
		{
			get => GetPropertyValue<CHandle<CustomDeviceAction>>();
			set => SetPropertyValue<CHandle<CustomDeviceAction>>(value);
		}

		public GenericDevice()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
