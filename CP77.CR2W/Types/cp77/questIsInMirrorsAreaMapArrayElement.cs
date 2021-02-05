using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questIsInMirrorsAreaMapArrayElement : CVariable
	{
		[Ordinal(0)]  [RED("objectRef")] public NodeRef ObjectRef { get; set; }
		[Ordinal(1)]  [RED("isInMirrorsArea")] public CBool IsInMirrorsArea { get; set; }

		public questIsInMirrorsAreaMapArrayElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
