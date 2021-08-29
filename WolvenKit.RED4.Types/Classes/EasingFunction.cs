using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EasingFunction : RedBaseClass
	{
		private CEnum<ETransitionType> _transitionType;
		private CEnum<EEasingType> _easingType;

		[Ordinal(0)] 
		[RED("transitionType")] 
		public CEnum<ETransitionType> TransitionType
		{
			get => GetProperty(ref _transitionType);
			set => SetProperty(ref _transitionType, value);
		}

		[Ordinal(1)] 
		[RED("easingType")] 
		public CEnum<EEasingType> EasingType
		{
			get => GetProperty(ref _easingType);
			set => SetProperty(ref _easingType, value);
		}
	}
}
