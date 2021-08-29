using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayTransformAnimationDeviceOperation : DeviceOperationBase
	{
		private CArray<STransformAnimationData> _transformAnimations;

		[Ordinal(5)] 
		[RED("transformAnimations")] 
		public CArray<STransformAnimationData> TransformAnimations
		{
			get => GetProperty(ref _transformAnimations);
			set => SetProperty(ref _transformAnimations, value);
		}
	}
}
