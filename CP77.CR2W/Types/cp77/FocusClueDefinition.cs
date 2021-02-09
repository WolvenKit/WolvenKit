using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FocusClueDefinition : CVariable
	{
		[Ordinal(0)]  [RED("extendedClueRecords")] public CArray<ClueRecordData> ExtendedClueRecords { get; set; }
		[Ordinal(1)]  [RED("clueRecord")] public TweakDBID ClueRecord { get; set; }
		[Ordinal(2)]  [RED("factToActivate")] public CName FactToActivate { get; set; }
		[Ordinal(3)]  [RED("facts")] public CArray<SFactOperationData> Facts { get; set; }
		[Ordinal(4)]  [RED("useAutoInspect")] public CBool UseAutoInspect { get; set; }
		[Ordinal(5)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(6)]  [RED("isProgressing")] public CBool IsProgressing { get; set; }
		[Ordinal(7)]  [RED("clueGroupID")] public CName ClueGroupID { get; set; }
		[Ordinal(8)]  [RED("wasInspected")] public CBool WasInspected { get; set; }
		[Ordinal(9)]  [RED("qDbCallbackID")] public CUInt32 QDbCallbackID { get; set; }
		[Ordinal(10)]  [RED("conclusionQuestState")] public CEnum<EConclusionQuestState> ConclusionQuestState { get; set; }

		public FocusClueDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
