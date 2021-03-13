using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldShadowConfig : CVariable
	{
		[Ordinal(0)] [RED("contactShadows")] public ContactShadowsConfig ContactShadows { get; set; }
		[Ordinal(1)] [RED("distantShadowsNumLevels")] public CUInt32 DistantShadowsNumLevels { get; set; }
		[Ordinal(2)] [RED("distantShadowsBaseLevelRadius")] public CFloat DistantShadowsBaseLevelRadius { get; set; }
		[Ordinal(3)] [RED("foliageShadowConfig")] public FoliageShadowConfig FoliageShadowConfig { get; set; }

		public WorldShadowConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
