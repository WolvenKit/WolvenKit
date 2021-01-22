using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class interopTerrainEditToolCreationSlotInfo : CVariable
	{
		[Ordinal(0)]  [RED("heightMappingMax")] public CFloat HeightMappingMax { get; set; }
		[Ordinal(1)]  [RED("heightMappingMin")] public CFloat HeightMappingMin { get; set; }
		[Ordinal(2)]  [RED("heightMappingOverrideEnable")] public CBool HeightMappingOverrideEnable { get; set; }
		[Ordinal(3)]  [RED("scale")] public Vector2 Scale { get; set; }

		public interopTerrainEditToolCreationSlotInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
