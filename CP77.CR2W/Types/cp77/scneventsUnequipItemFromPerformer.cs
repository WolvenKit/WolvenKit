using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scneventsUnequipItemFromPerformer : scnSceneEvent
	{
		[Ordinal(6)] [RED("performerId")] public scnPerformerId PerformerId { get; set; }
		[Ordinal(7)] [RED("slotId")] public TweakDBID SlotId { get; set; }
		[Ordinal(8)] [RED("restoreGameplayItem")] public CBool RestoreGameplayItem { get; set; }

		public scneventsUnequipItemFromPerformer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
