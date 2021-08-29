using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FastForwardAvailableEvents : ScenesFastForwardTransition
	{
		private CBool _forceCloseFX;
		private CFloat _delay;

		[Ordinal(0)] 
		[RED("forceCloseFX")] 
		public CBool ForceCloseFX
		{
			get => GetProperty(ref _forceCloseFX);
			set => SetProperty(ref _forceCloseFX, value);
		}

		[Ordinal(1)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetProperty(ref _delay);
			set => SetProperty(ref _delay, value);
		}
	}
}
