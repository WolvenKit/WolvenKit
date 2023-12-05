using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entMechanicalImpactComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("c_impulseMagThreshold")] 
		public CFloat C_impulseMagThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public entMechanicalImpactComponent()
		{
			Name = "Component";
			C_impulseMagThreshold = 10000.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
