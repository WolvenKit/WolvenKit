using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnTimedCondition : ISerializable
	{
		[Ordinal(0)]  [RED("duration")] public scnSceneTime Duration { get; set; }
		[Ordinal(1)]  [RED("action")] public CEnum<scnChoiceNodeNsTimedAction> Action { get; set; }
		[Ordinal(2)]  [RED("timeLimitedFinish")] public CBool TimeLimitedFinish { get; set; }

		public scnTimedCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
