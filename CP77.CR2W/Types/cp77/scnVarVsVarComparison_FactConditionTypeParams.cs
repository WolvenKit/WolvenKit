using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnVarVsVarComparison_FactConditionTypeParams : CVariable
	{
		[Ordinal(0)]  [RED("comparisonType")] public CEnum<EComparisonType> ComparisonType { get; set; }
		[Ordinal(1)]  [RED("factName1")] public CName FactName1 { get; set; }
		[Ordinal(2)]  [RED("factName2")] public CName FactName2 { get; set; }

		public scnVarVsVarComparison_FactConditionTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
