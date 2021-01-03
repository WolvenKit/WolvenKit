using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameReplAnimTransformSyncElem : CVariable
	{
		[Ordinal(0)]  [RED("currentTime")] public CFloat CurrentTime { get; set; }
		[Ordinal(1)]  [RED("definitionId")] public CInt32 DefinitionId { get; set; }
		[Ordinal(2)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(3)]  [RED("playing")] public CBool Playing { get; set; }
		[Ordinal(4)]  [RED("timeScale")] public CFloat TimeScale { get; set; }
		[Ordinal(5)]  [RED("timesToPlay")] public CInt32 TimesToPlay { get; set; }

		public gameReplAnimTransformSyncElem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
