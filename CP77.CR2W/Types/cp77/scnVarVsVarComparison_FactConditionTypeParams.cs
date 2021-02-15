using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnVarVsVarComparison_FactConditionTypeParams : CVariable
	{
		[Ordinal(0)] [RED("factName1")] public CName FactName1 { get; set; }
		[Ordinal(1)] [RED("factName2")] public CName FactName2 { get; set; }
		[Ordinal(2)] [RED("comparisonType")] public CEnum<EComparisonType> ComparisonType { get; set; }

		public scnVarVsVarComparison_FactConditionTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
