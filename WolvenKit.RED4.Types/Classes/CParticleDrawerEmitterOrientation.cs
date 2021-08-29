using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleDrawerEmitterOrientation : IParticleDrawer
	{
		private EulerAngles _coordinateSystem;
		private CBool _isGPUBased;

		[Ordinal(1)] 
		[RED("coordinateSystem")] 
		public EulerAngles CoordinateSystem
		{
			get => GetProperty(ref _coordinateSystem);
			set => SetProperty(ref _coordinateSystem, value);
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
