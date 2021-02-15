using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class workCoverTypeCondition : workIWorkspotCondition
	{
		[Ordinal(2)] [RED("isHighCover")] public CBool IsHighCover { get; set; }

		public workCoverTypeCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
