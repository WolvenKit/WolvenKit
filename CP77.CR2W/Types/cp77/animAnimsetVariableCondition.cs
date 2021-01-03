using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimsetVariableCondition : animIRuntimeCondition
	{
		[Ordinal(0)]  [RED("valueToCompare")] public CFloat ValueToCompare { get; set; }
		[Ordinal(1)]  [RED("variableToCompare")] public CName VariableToCompare { get; set; }

		public animAnimsetVariableCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
