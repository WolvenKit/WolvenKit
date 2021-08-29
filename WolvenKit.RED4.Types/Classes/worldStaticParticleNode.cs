using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldStaticParticleNode : worldNode
	{
		private CFloat _emissionRate;
		private CResourceAsyncReference<CParticleSystem> _particleSystem;
		private CFloat _forcedAutoHideDistance;
		private CFloat _forcedAutoHideRange;

		[Ordinal(4)] 
		[RED("emissionRate")] 
		public CFloat EmissionRate
		{
			get => GetProperty(ref _emissionRate);
			set => SetProperty(ref _emissionRate, value);
		}

		[Ordinal(5)] 
		[RED("particleSystem")] 
		public CResourceAsyncReference<CParticleSystem> ParticleSystem
		{
			get => GetProperty(ref _particleSystem);
			set => SetProperty(ref _particleSystem, value);
		}

		[Ordinal(6)] 
		[RED("forcedAutoHideDistance")] 
		public CFloat ForcedAutoHideDistance
		{
			get => GetProperty(ref _forcedAutoHideDistance);
			set => SetProperty(ref _forcedAutoHideDistance, value);
		}

		[Ordinal(7)] 
		[RED("forcedAutoHideRange")] 
		public CFloat ForcedAutoHideRange
		{
			get => GetProperty(ref _forcedAutoHideRange);
			set => SetProperty(ref _forcedAutoHideRange, value);
		}
	}
}
