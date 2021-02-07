using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldDbgOverlapBox : CVariable
	{
		[Ordinal(0)]  [RED("box")] public Box Box { get; set; }
		[Ordinal(1)]  [RED("transform")] public Transform Transform { get; set; }
		[Ordinal(2)]  [RED("level")] public CUInt32 Level { get; set; }
		[Ordinal(3)]  [RED("isHit")] public CBool IsHit { get; set; }

		public worldDbgOverlapBox(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
