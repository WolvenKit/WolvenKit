using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnVarVsVarComparison_FactConditionType : scnInterruptFactConditionType
	{
		[Ordinal(0)] [RED("params")] public scnVarVsVarComparison_FactConditionTypeParams Params { get; set; }

		public scnVarVsVarComparison_FactConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
