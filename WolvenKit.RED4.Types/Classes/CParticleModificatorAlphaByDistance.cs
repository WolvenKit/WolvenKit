using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleModificatorAlphaByDistance : IParticleModificator
	{
		private Vector2 _nearBlendDistance;
		private Vector2 _farBlendDistance;

		[Ordinal(4)] 
		[RED("nearBlendDistance")] 
		public Vector2 NearBlendDistance
		{
			get => GetProperty(ref _nearBlendDistance);
			set => SetProperty(ref _nearBlendDistance, value);
		}

		[Ordinal(5)] 
		[RED("farBlendDistance")] 
		public Vector2 FarBlendDistance
		{
			get => GetProperty(ref _farBlendDistance);
			set => SetProperty(ref _farBlendDistance, value);
		}
	}
}
