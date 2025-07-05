using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class gameuiPanzerBonus : gameuiSideScrollerMiniGameDynObjectLogicAdvanced
	{
		[Ordinal(1)] 
		[RED("fallingSpeed")] 
		public CFloat FallingSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiPanzerBonus()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
