using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldStaticParticleNode : worldNode
	{
		[Ordinal(0)]  [RED("emissionRate")] public CFloat EmissionRate { get; set; }
		[Ordinal(1)]  [RED("forcedAutoHideDistance")] public CFloat ForcedAutoHideDistance { get; set; }
		[Ordinal(2)]  [RED("forcedAutoHideRange")] public CFloat ForcedAutoHideRange { get; set; }
		[Ordinal(3)]  [RED("particleSystem")] public raRef<CParticleSystem> ParticleSystem { get; set; }

		public worldStaticParticleNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
