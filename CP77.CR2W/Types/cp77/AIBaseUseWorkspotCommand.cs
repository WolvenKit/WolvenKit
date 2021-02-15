using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIBaseUseWorkspotCommand : AICommand
	{
		[Ordinal(4)] [RED("moveToWorkspot")] public CBool MoveToWorkspot { get; set; }
		[Ordinal(5)] [RED("forceEntryAnimName")] public CName ForceEntryAnimName { get; set; }
		[Ordinal(6)] [RED("workExcludedGestures")] public CArray<workWorkEntryId> WorkExcludedGestures { get; set; }
		[Ordinal(7)] [RED("infiniteSequenceEntryId")] public workWorkEntryId InfiniteSequenceEntryId { get; set; }
		[Ordinal(8)] [RED("idleOnlyMode")] public CBool IdleOnlyMode { get; set; }
		[Ordinal(9)] [RED("continueInCombat")] public CBool ContinueInCombat { get; set; }
		[Ordinal(10)] [RED("movementType")] public CEnum<moveMovementType> MovementType { get; set; }

		public AIBaseUseWorkspotCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
