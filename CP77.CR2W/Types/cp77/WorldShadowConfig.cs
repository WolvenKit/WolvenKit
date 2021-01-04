using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WorldShadowConfig : CVariable
	{
		[Ordinal(0)]  [RED("contactShadows")] public ContactShadowsConfig ContactShadows { get; set; }
		[Ordinal(1)]  [RED("distantShadowsBaseLevelRadius")] public CFloat DistantShadowsBaseLevelRadius { get; set; }
		[Ordinal(2)]  [RED("distantShadowsNumLevels")] public CUInt32 DistantShadowsNumLevels { get; set; }
		[Ordinal(3)]  [RED("foliageShadowConfig")] public FoliageShadowConfig FoliageShadowConfig { get; set; }

		public WorldShadowConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
