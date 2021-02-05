using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamePrereqCheckData : CVariable
	{
		[Ordinal(0)]  [RED("prereqType")] public CEnum<gameEPrerequisiteType> PrereqType { get; set; }
		[Ordinal(1)]  [RED("comparisonType")] public CEnum<EComparisonType> ComparisonType { get; set; }
		[Ordinal(2)]  [RED("contextObject")] public CString ContextObject { get; set; }
		[Ordinal(3)]  [RED("valueToCompare")] public CFloat ValueToCompare { get; set; }

		public gamePrereqCheckData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
