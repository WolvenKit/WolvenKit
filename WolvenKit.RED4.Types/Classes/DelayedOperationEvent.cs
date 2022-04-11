using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DelayedOperationEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("operationHandler")] 
		public CHandle<DeviceOperations> OperationHandler
		{
			get => GetPropertyValue<CHandle<DeviceOperations>>();
			set => SetPropertyValue<CHandle<DeviceOperations>>(value);
		}

		[Ordinal(1)] 
		[RED("operation")] 
		public SBaseDeviceOperationData Operation
		{
			get => GetPropertyValue<SBaseDeviceOperationData>();
			set => SetPropertyValue<SBaseDeviceOperationData>(value);
		}

		public DelayedOperationEvent()
		{
			Operation = new() { IsEnabled = true, TransformAnimations = new(), VFXs = new(), SFXs = new(), Facts = new(), Components = new(), Stims = new(), StatusEffects = new(), Damages = new(), Items = new(), Teleport = new(), PlayerWorkspot = new(), ToggleOperations = new(), DelayID = new() };
		}
	}
}
