using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entParticlesComponent : entIVisualComponent
	{
		[Ordinal(0)]  [RED("autoHideRange")] public CFloat AutoHideRange { get; set; }
		[Ordinal(1)]  [RED("emissionRate")] public CFloat EmissionRate { get; set; }
		[Ordinal(2)]  [RED("particleSystem")] public rRef<CParticleSystem> ParticleSystem { get; set; }
		[Ordinal(3)]  [RED("renderLayerMask")] public CEnum<RenderSceneLayerMask> RenderLayerMask { get; set; }

		public entParticlesComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
