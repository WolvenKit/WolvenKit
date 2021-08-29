using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleDrawerSphereAligned : IParticleDrawer
	{
		private CBool _verticalFixed;
		private CBool _isGPUBased;

		[Ordinal(1)] 
		[RED("verticalFixed")] 
		public CBool VerticalFixed
		{
			get => GetProperty(ref _verticalFixed);
			set => SetProperty(ref _verticalFixed, value);
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
