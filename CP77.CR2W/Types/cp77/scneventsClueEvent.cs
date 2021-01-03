using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scneventsClueEvent : scnSceneEvent
	{
		[Ordinal(0)]  [RED("clueEntity")] public gameEntityReference ClueEntity { get; set; }
		[Ordinal(1)]  [RED("clueName")] public CName ClueName { get; set; }
		[Ordinal(2)]  [RED("factName")] public CName FactName { get; set; }
		[Ordinal(3)]  [RED("layer")] public CEnum<gameuiEBraindanceLayer> Layer { get; set; }
		[Ordinal(4)]  [RED("markedOnTimeline")] public CBool MarkedOnTimeline { get; set; }
		[Ordinal(5)]  [RED("overrideFact")] public CBool OverrideFact { get; set; }

		public scneventsClueEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
