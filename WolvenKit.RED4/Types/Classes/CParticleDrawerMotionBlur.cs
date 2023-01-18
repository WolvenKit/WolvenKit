using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleDrawerMotionBlur : IParticleDrawer
	{
		[Ordinal(1)] 
		[RED("stretchPerVelocity")] 
		public CFloat StretchPerVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("isGPUBased")] 
		public CBool IsGPUBased
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CParticleDrawerMotionBlur()
		{
			StretchPerVelocity = 0.500000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
