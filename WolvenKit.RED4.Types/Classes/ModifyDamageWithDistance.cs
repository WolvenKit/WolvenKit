using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModifyDamageWithDistance : ModifyDamageEffector
	{
		[Ordinal(2)] 
		[RED("increaseWithDistance")] 
		public CBool IncreaseWithDistance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("percentMult")] 
		public CFloat PercentMult
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("unitThreshold")] 
		public CFloat UnitThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ModifyDamageWithDistance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
