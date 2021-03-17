using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorAlphaByDistance : IParticleModificator
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

		public CParticleModificatorAlphaByDistance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
