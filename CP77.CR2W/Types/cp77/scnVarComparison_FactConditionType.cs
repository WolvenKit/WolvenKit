using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnVarComparison_FactConditionType : scnInterruptFactConditionType
	{
		[Ordinal(0)]  [RED("params")] public scnVarComparison_FactConditionTypeParams Params { get; set; }

		public scnVarComparison_FactConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
