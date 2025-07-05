using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectExecutor_PhysicalImpulseFromInstigator_Value : gameEffectExecutor
	{
		[Ordinal(1)] 
		[RED("magnitude")] 
		public CFloat Magnitude
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("forceUseHitPosition")] 
		public CBool ForceUseHitPosition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameEffectExecutor_PhysicalImpulseFromInstigator_Value()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
