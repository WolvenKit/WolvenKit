using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questTransformAnimatorNode_Action_Play : questTransformAnimatorNode_ActionType
	{
		[Ordinal(0)]  [RED("reverse")] public CBool Reverse { get; set; }
		[Ordinal(1)]  [RED("timeScale")] public CFloat TimeScale { get; set; }
		[Ordinal(2)]  [RED("timesPlayed")] public CInt32 TimesPlayed { get; set; }
		[Ordinal(3)]  [RED("useEntitySetup")] public CBool UseEntitySetup { get; set; }

		public questTransformAnimatorNode_Action_Play(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
