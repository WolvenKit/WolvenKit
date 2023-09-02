using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SDoorStateOperationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<EDoorStatus> State
		{
			get => GetPropertyValue<CEnum<EDoorStatus>>();
			set => SetPropertyValue<CEnum<EDoorStatus>>(value);
		}

		[Ordinal(1)] 
		[RED("operation")] 
		public SBaseDeviceOperationData Operation
		{
			get => GetPropertyValue<SBaseDeviceOperationData>();
			set => SetPropertyValue<SBaseDeviceOperationData>(value);
		}

		public SDoorStateOperationData()
		{
			Operation = new SBaseDeviceOperationData { IsEnabled = true, TransformAnimations = new(), VFXs = new(), SFXs = new(), Facts = new(), Components = new(), Stims = new(), StatusEffects = new(), Damages = new(), Items = new(), Teleport = new STeleportOperationData(), PlayerWorkspot = new SWorkspotData(), ToggleOperations = new(), DelayID = new gameDelayID() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
