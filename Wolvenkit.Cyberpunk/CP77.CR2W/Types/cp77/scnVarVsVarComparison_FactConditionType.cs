using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnVarVsVarComparison_FactConditionType : scnInterruptFactConditionType
	{
		[Ordinal(0)]  [RED("params")] public scnVarVsVarComparison_FactConditionTypeParams Params { get; set; }

		public scnVarVsVarComparison_FactConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
