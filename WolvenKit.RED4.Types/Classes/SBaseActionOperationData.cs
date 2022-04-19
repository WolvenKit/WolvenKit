using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SBaseActionOperationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("action")] 
		public CHandle<ScriptableDeviceAction> Action
		{
			get => GetPropertyValue<CHandle<ScriptableDeviceAction>>();
			set => SetPropertyValue<CHandle<ScriptableDeviceAction>>(value);
		}

		[Ordinal(1)] 
		[RED("operation")] 
		public SBaseDeviceOperationData Operation
		{
			get => GetPropertyValue<SBaseDeviceOperationData>();
			set => SetPropertyValue<SBaseDeviceOperationData>(value);
		}

		public SBaseActionOperationData()
		{
			Operation = new() { IsEnabled = true, TransformAnimations = new(), VFXs = new(), SFXs = new(), Facts = new(), Components = new(), Stims = new(), StatusEffects = new(), Damages = new(), Items = new(), Teleport = new(), PlayerWorkspot = new(), ToggleOperations = new(), DelayID = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
