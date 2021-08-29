using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActivatedDeviceIndustrialArm : ActivatedDeviceTrap
	{
		private CEnum<EIndustrialArmAnimations> _loopAnimation;

		[Ordinal(99)] 
		[RED("loopAnimation")] 
		public CEnum<EIndustrialArmAnimations> LoopAnimation
		{
			get => GetProperty(ref _loopAnimation);
			set => SetProperty(ref _loopAnimation, value);
		}
	}
}
