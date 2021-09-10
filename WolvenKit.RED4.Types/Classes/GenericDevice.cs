using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GenericDevice : InteractiveDevice
	{
		[Ordinal(97)] 
		[RED("offMeshConnectionComponent")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionComponent
		{
			get => GetPropertyValue<CHandle<AIOffMeshConnectionComponent>>();
			set => SetPropertyValue<CHandle<AIOffMeshConnectionComponent>>(value);
		}

		[Ordinal(98)] 
		[RED("currentSpiderbotAction")] 
		public CHandle<CustomDeviceAction> CurrentSpiderbotAction
		{
			get => GetPropertyValue<CHandle<CustomDeviceAction>>();
			set => SetPropertyValue<CHandle<CustomDeviceAction>>(value);
		}

		public GenericDevice()
		{
			ControllerTypeName = "GenericDeviceController";
		}
	}
}
