using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CurveResourceSetEntry : CVariable
	{
		[Ordinal(0)]  [RED("curveResRef")] public rRef<CurveSet> CurveResRef { get; set; }
		[Ordinal(1)]  [RED("name")] public CName Name { get; set; }

		public CurveResourceSetEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
