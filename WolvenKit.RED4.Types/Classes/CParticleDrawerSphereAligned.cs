using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleDrawerSphereAligned : IParticleDrawer
	{
		[Ordinal(1)] 
		[RED("verticalFixed")] 
		public CBool VerticalFixed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isGPUBased")] 
		public CBool IsGPUBased
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CParticleDrawerSphereAligned()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
