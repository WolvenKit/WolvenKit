using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entdismembermentPhysicsInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("DensityScale")] 
		public CFloat DensityScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public entdismembermentPhysicsInfo()
		{
			DensityScale = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
