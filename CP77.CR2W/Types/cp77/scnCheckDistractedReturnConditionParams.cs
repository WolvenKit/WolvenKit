using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnCheckDistractedReturnConditionParams : CVariable
	{
		[Ordinal(0)] [RED("distracted")] public CBool Distracted { get; set; }
		[Ordinal(1)] [RED("target")] public CEnum<scnDistractedConditionTarget> Target { get; set; }

		public scnCheckDistractedReturnConditionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
