using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModifyDamageWithLeapedDistance : ModifyDamageEffector
	{
		[Ordinal(6)] 
		[RED("maxPercentMult")] 
		public CFloat MaxPercentMult
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("minDistance")] 
		public CFloat MinDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ModifyDamageWithLeapedDistance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
