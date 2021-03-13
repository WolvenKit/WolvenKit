using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisBluelinePart : IScriptable
	{
		[Ordinal(0)] [RED("passed")] public CBool Passed { get; set; }
		[Ordinal(1)] [RED("captionIconRecordId")] public TweakDBID CaptionIconRecordId { get; set; }

		public gameinteractionsvisBluelinePart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
