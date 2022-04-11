using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleDrawerBeam : CParticleDrawerFacingBeam
	{
		[Ordinal(9)] 
		[RED("rotation")] 
		public CFloat Rotation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
