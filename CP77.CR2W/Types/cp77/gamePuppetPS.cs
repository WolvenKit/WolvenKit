using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamePuppetPS : gameObjectPS
	{
		[Ordinal(0)] [RED("gender")] public CName Gender { get; set; }
		[Ordinal(1)] [RED("wasQuickHacked")] public CBool WasQuickHacked { get; set; }
		[Ordinal(2)] [RED("hasAlternativeName")] public CBool HasAlternativeName { get; set; }
		[Ordinal(3)] [RED("isCrouch")] public CBool IsCrouch { get; set; }

		public gamePuppetPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
