using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorAlphaByDistance : IParticleModificator
	{
		[Ordinal(4)] [RED("nearBlendDistance")] public Vector2 NearBlendDistance { get; set; }
		[Ordinal(5)] [RED("farBlendDistance")] public Vector2 FarBlendDistance { get; set; }

		public CParticleModificatorAlphaByDistance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
