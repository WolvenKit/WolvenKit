using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldStaticParticleNode : worldNode
	{
		[Ordinal(2)] 
		[RED("emissionRate")] 
		public CFloat EmissionRate
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("particleSystem")] 
		public CResourceAsyncReference<CParticleSystem> ParticleSystem
		{
			get => GetPropertyValue<CResourceAsyncReference<CParticleSystem>>();
			set => SetPropertyValue<CResourceAsyncReference<CParticleSystem>>(value);
		}

		[Ordinal(4)] 
		[RED("forcedAutoHideDistance")] 
		public CFloat ForcedAutoHideDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("forcedAutoHideRange")] 
		public CFloat ForcedAutoHideRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldStaticParticleNode()
		{
			ForcedAutoHideDistance = -1.000000F;
			ForcedAutoHideRange = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
