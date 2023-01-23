using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayTransformAnimationDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] 
		[RED("transformAnimations")] 
		public CArray<STransformAnimationData> TransformAnimations
		{
			get => GetPropertyValue<CArray<STransformAnimationData>>();
			set => SetPropertyValue<CArray<STransformAnimationData>>(value);
		}

		public PlayTransformAnimationDeviceOperation()
		{
			IsEnabled = true;
			ToggleOperations = new();
			TransformAnimations = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
