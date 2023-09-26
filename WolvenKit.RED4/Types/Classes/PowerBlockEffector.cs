using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PowerBlockEffector : ModifyAttackEffector
	{
		[Ordinal(0)] 
		[RED("damageReduction")] 
		public CFloat DamageReduction
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public PowerBlockEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
