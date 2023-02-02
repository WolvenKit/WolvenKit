using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SBaseStateOperationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<EDeviceStatus> State
		{
			get => GetPropertyValue<CEnum<EDeviceStatus>>();
			set => SetPropertyValue<CEnum<EDeviceStatus>>(value);
		}

		[Ordinal(1)] 
		[RED("operation")] 
		public SBaseDeviceOperationData Operation
		{
			get => GetPropertyValue<SBaseDeviceOperationData>();
			set => SetPropertyValue<SBaseDeviceOperationData>(value);
		}

		public SBaseStateOperationData()
		{
			Operation = new() { IsEnabled = true, TransformAnimations = new(), VFXs = new(), SFXs = new(), Facts = new(), Components = new(), Stims = new(), StatusEffects = new(), Damages = new(), Items = new(), Teleport = new(), PlayerWorkspot = new(), ToggleOperations = new(), DelayID = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
