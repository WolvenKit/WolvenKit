using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiDriverCombatCrosshairReticleData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<gameuiDriverCombatCrosshairReticleDataState> State
		{
			get => GetPropertyValue<CEnum<gameuiDriverCombatCrosshairReticleDataState>>();
			set => SetPropertyValue<CEnum<gameuiDriverCombatCrosshairReticleDataState>>(value);
		}

		[Ordinal(1)] 
		[RED("opacity")] 
		public CFloat Opacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiDriverCombatCrosshairReticleData()
		{
			Opacity = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
