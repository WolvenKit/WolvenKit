using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeirdTankyPlatingEffector : ModifyAttackEffector
	{
		[Ordinal(0)] 
		[RED("armorMultiplier")] 
		public CFloat ArmorMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public WeirdTankyPlatingEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
