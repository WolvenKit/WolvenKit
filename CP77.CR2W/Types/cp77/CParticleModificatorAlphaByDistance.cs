using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorAlphaByDistance : IParticleModificator
	{
		[Ordinal(0)]  [RED("farBlendDistance")] public Vector2 FarBlendDistance { get; set; }
		[Ordinal(1)]  [RED("nearBlendDistance")] public Vector2 NearBlendDistance { get; set; }

		public CParticleModificatorAlphaByDistance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
