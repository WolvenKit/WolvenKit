using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FastForwardAvailableEvents : ScenesFastForwardTransition
	{
		[Ordinal(0)] 
		[RED("forceCloseFX")] 
		public CBool ForceCloseFX
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public FastForwardAvailableEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
