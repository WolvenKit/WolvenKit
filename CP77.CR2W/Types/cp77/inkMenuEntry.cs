using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkMenuEntry : CVariable
	{
		[Ordinal(0)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(1)]  [RED("menuWidget")] public rRef<inkWidgetLibraryResource> MenuWidget { get; set; }
		[Ordinal(2)]  [RED("depth")] public CUInt32 Depth { get; set; }
		[Ordinal(3)]  [RED("spawnMode")] public CEnum<inkSpawnMode> SpawnMode { get; set; }
		[Ordinal(4)]  [RED("isAffectedByFadeout")] public CBool IsAffectedByFadeout { get; set; }

		public inkMenuEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
