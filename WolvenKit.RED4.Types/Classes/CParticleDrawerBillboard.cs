using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleDrawerBillboard : IParticleDrawer
	{
		private CBool _isGPUBased;

		[Ordinal(1)] 
		[RED("isGPUBased")] 
		public CBool IsGPUBased
		{
			get => GetProperty(ref _isGPUBased);
			set => SetProperty(ref _isGPUBased, value);
		}
	}
}
