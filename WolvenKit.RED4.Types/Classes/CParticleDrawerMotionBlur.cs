using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleDrawerMotionBlur : IParticleDrawer
	{
		private CFloat _stretchPerVelocity;
		private CBool _isGPUBased;

		[Ordinal(1)] 
		[RED("stretchPerVelocity")] 
		public CFloat StretchPerVelocity
		{
			get => GetProperty(ref _stretchPerVelocity);
			set => SetProperty(ref _stretchPerVelocity, value);
		}

		[Ordinal(2)] 
		[RED("isGPUBased")] 
		public CBool IsGPUBased
		{
			get => GetProperty(ref _isGPUBased);
			set => SetProperty(ref _isGPUBased, value);
		}
	}
}
