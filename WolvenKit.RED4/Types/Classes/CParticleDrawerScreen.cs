using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleDrawerScreen : IParticleDrawer
	{
		[Ordinal(1)] 
		[RED("isGPUBased")] 
		public CBool IsGPUBased
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CParticleDrawerScreen()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
