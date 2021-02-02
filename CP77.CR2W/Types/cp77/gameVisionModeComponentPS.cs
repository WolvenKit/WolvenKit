using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameVisionModeComponentPS : gameComponentPS
	{
		[Ordinal(0)]  [RED("hideInDefaultMode")] public CBool HideInDefaultMode { get; set; }
		[Ordinal(1)]  [RED("hideInFocusMode")] public CBool HideInFocusMode { get; set; }
		[Ordinal(2)]  [RED("inactive")] public CBool Inactive { get; set; }
		[Ordinal(3)]  [RED("questInactive")] public CBool QuestInactive { get; set; }
		[Ordinal(4)]  [RED("questForcedMeshes")] public CArray<CName> QuestForcedMeshes { get; set; }
		[Ordinal(5)]  [RED("questForcedModules")] public CArray<CName> QuestForcedModules { get; set; }

		public gameVisionModeComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
