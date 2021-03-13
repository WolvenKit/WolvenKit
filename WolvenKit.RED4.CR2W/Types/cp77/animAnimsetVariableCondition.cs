using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimsetVariableCondition : animIRuntimeCondition
	{
		[Ordinal(0)] [RED("variableToCompare")] public CName VariableToCompare { get; set; }
		[Ordinal(1)] [RED("valueToCompare")] public CFloat ValueToCompare { get; set; }

		public animAnimsetVariableCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
