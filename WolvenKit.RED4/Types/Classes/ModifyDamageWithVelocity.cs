using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModifyDamageWithVelocity : ModifyDamageEffector
	{
		[Ordinal(6)] 
		[RED("percentMult")] 
		public CFloat PercentMult
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("unitThreshold")] 
		public CFloat UnitThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ModifyDamageWithVelocity()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
