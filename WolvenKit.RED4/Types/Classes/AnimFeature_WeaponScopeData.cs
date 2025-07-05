using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_WeaponScopeData : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("ironsightAngleWithScope")] 
		public CFloat IronsightAngleWithScope
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("hasScope")] 
		public CBool HasScope
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimFeature_WeaponScopeData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
