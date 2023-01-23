using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleDrawerBeam : CParticleDrawerFacingBeam
	{
		[Ordinal(9)] 
		[RED("rotation")] 
		public CFloat Rotation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CParticleDrawerBeam()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
