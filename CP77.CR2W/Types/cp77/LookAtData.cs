using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LookAtData : CVariable
	{
		[Ordinal(0)]  [RED("idle")] public CInt32 Idle { get; set; }
		[Ordinal(1)]  [RED("category")] public CInt32 Category { get; set; }
		[Ordinal(2)]  [RED("personality")] public CEnum<gamedataStatType> Personality { get; set; }

		public LookAtData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
