using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleDrawerBeam : CParticleDrawerFacingBeam
	{
		private CFloat _rotation;

		[Ordinal(9)] 
		[RED("rotation")] 
		public CFloat Rotation
		{
			get => GetProperty(ref _rotation);
			set => SetProperty(ref _rotation, value);
		}
	}
}
