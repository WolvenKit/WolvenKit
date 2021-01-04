using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questUseWorkspotParamsV1 : questAICommandParams
	{
		[Ordinal(0)]  [RED("changeWorkspot")] public CBool ChangeWorkspot { get; set; }
		[Ordinal(1)]  [RED("continueInCombat")] public CBool ContinueInCombat { get; set; }
		[Ordinal(2)]  [RED("enableIdleMode")] public CBool EnableIdleMode { get; set; }
		[Ordinal(3)]  [RED("entryId")] public workWorkEntryId EntryId { get; set; }
		[Ordinal(4)]  [RED("entryTag")] public CName EntryTag { get; set; }
		[Ordinal(5)]  [RED("exitAnimName")] public CName ExitAnimName { get; set; }
		[Ordinal(6)]  [RED("exitEntryId")] public workWorkEntryId ExitEntryId { get; set; }
		[Ordinal(7)]  [RED("finishAnimation")] public CBool FinishAnimation { get; set; }
		[Ordinal(8)]  [RED("forceEntryAnimName")] public CName ForceEntryAnimName { get; set; }
		[Ordinal(9)]  [RED("function")] public CEnum<questUseWorkspotNodeFunctions> Function { get; set; }
		[Ordinal(10)]  [RED("instant")] public CBool Instant { get; set; }
		[Ordinal(11)]  [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(12)]  [RED("isWorkspotInfinite")] public CBool IsWorkspotInfinite { get; set; }
		[Ordinal(13)]  [RED("jumpToEntry")] public CBool JumpToEntry { get; set; }
		[Ordinal(14)]  [RED("maxAnimTimeLimit")] public CFloat MaxAnimTimeLimit { get; set; }
		[Ordinal(15)]  [RED("movementType")] public CEnum<moveMovementType> MovementType { get; set; }
		[Ordinal(16)]  [RED("playerParams")] public questUseWorkspotPlayerParams PlayerParams { get; set; }
		[Ordinal(17)]  [RED("repeatCommandOnInterrupt")] public CBool RepeatCommandOnInterrupt { get; set; }
		[Ordinal(18)]  [RED("teleport")] public CBool Teleport { get; set; }
		[Ordinal(19)]  [RED("workExcludedGestures")] public CArray<workWorkEntryId> WorkExcludedGestures { get; set; }
		[Ordinal(20)]  [RED("workspotNode")] public NodeRef WorkspotNode { get; set; }

		public questUseWorkspotParamsV1(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
