using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CluePSData : IScriptable
	{
		[Ordinal(0)]  [RED("id")] public CInt32 Id { get; set; }
		[Ordinal(1)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(2)]  [RED("wasInspected")] public CBool WasInspected { get; set; }
		[Ordinal(3)]  [RED("isScanned")] public CBool IsScanned { get; set; }
		[Ordinal(4)]  [RED("conclusionQuestState")] public CEnum<EConclusionQuestState> ConclusionQuestState { get; set; }

		public CluePSData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
