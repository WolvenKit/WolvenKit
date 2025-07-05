using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModifyCritWithDistance : ModifyAttackEffector
	{
		[Ordinal(0)] 
		[RED("critChanceBonus")] 
		public CFloat CritChanceBonus
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("minDistance")] 
		public CFloat MinDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("improveWithDistance")] 
		public CBool ImproveWithDistance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ModifyCritWithDistance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
