using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FactValuePrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] [RED("fact")] public CName Fact { get; set; }
		[Ordinal(1)] [RED("value")] public CInt32 Value { get; set; }
		[Ordinal(2)] [RED("comparisonType")] public CEnum<EComparisonType> ComparisonType { get; set; }

		public FactValuePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
