using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldBlockoutEdge : CVariable
	{
		[Ordinal(0)]  [RED("points", 2)] public CArrayFixedSize<CUInt32> Points { get; set; }
		[Ordinal(1)]  [RED("areas", 2)] public CArrayFixedSize<CUInt32> Areas { get; set; }
		[Ordinal(2)]  [RED("isFree")] public CBool IsFree { get; set; }

		public worldBlockoutEdge(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
