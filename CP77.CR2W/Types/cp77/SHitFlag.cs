using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SHitFlag : CVariable
	{
		[Ordinal(0)]  [RED("flag")] public CEnum<hitFlag> Flag { get; set; }
		[Ordinal(1)]  [RED("source")] public CName Source { get; set; }

		public SHitFlag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
