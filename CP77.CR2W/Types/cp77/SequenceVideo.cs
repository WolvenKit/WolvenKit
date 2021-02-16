using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SequenceVideo : CVariable
	{
		[Ordinal(0)] [RED("videoPath")] public redResourceReferenceScriptToken VideoPath { get; set; }
		[Ordinal(1)] [RED("audioEvent")] public CName AudioEvent { get; set; }
		[Ordinal(2)] [RED("looped")] public CBool Looped { get; set; }

		public SequenceVideo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
