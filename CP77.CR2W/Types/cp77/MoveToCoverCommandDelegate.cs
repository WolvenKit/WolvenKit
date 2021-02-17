using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MoveToCoverCommandDelegate : AIbehaviorScriptBehaviorDelegate
	{
		[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
		[Ordinal(1)] [RED("releaseSignalOnCoverEnter")] public CBool ReleaseSignalOnCoverEnter { get; set; }
		[Ordinal(2)] [RED("useSpecialAction")] public CBool UseSpecialAction { get; set; }
		[Ordinal(3)] [RED("useHigh")] public CBool UseHigh { get; set; }
		[Ordinal(4)] [RED("useLeft")] public CBool UseLeft { get; set; }
		[Ordinal(5)] [RED("useRight")] public CBool UseRight { get; set; }

		public MoveToCoverCommandDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
