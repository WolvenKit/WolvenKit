using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scneventsClueEvent : scnSceneEvent
	{
		[Ordinal(6)] [RED("clueEntity")] public gameEntityReference ClueEntity { get; set; }
		[Ordinal(7)] [RED("markedOnTimeline")] public CBool MarkedOnTimeline { get; set; }
		[Ordinal(8)] [RED("clueName")] public CName ClueName { get; set; }
		[Ordinal(9)] [RED("layer")] public CEnum<gameuiEBraindanceLayer> Layer { get; set; }
		[Ordinal(10)] [RED("overrideFact")] public CBool OverrideFact { get; set; }
		[Ordinal(11)] [RED("factName")] public CName FactName { get; set; }

		public scneventsClueEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
