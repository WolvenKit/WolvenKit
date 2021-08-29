using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SimpleSwitch : InteractiveMasterDevice
	{
		private CEnum<EAnimationType> _animationType;
		private CFloat _animationSpeed;

		[Ordinal(97)] 
		[RED("animationType")] 
		public CEnum<EAnimationType> AnimationType
		{
			get => GetProperty(ref _animationType);
			set => SetProperty(ref _animationType, value);
		}

		[Ordinal(98)] 
		[RED("animationSpeed")] 
		public CFloat AnimationSpeed
		{
			get => GetProperty(ref _animationSpeed);
			set => SetProperty(ref _animationSpeed, value);
		}
	}
}
