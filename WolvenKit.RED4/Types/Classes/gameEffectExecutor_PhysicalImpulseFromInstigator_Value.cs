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

		public gameEffectExecutor_PhysicalImpulseFromInstigator_Value()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
