using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TrespasserEntry : CVariable
	{
		[Ordinal(0)]  [RED("trespasser")] public wCHandle<gameObject> Trespasser { get; set; }
		[Ordinal(1)]  [RED("isScanned")] public CBool IsScanned { get; set; }
		[Ordinal(2)]  [RED("isInsideA")] public CBool IsInsideA { get; set; }
		[Ordinal(3)]  [RED("isInsideB")] public CBool IsInsideB { get; set; }
		[Ordinal(4)]  [RED("isInsideScanner")] public CBool IsInsideScanner { get; set; }
		[Ordinal(5)]  [RED("areaStack")] public CArray<CName> AreaStack { get; set; }

		public TrespasserEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
