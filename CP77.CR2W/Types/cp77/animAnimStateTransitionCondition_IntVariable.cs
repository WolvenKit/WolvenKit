using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_IntVariable : animIAnimStateTransitionCondition
	{
		[Ordinal(0)]  [RED("compareFunc")] public CEnum<animCompareFunc> CompareFunc { get; set; }
		[Ordinal(1)]  [RED("compareValue")] public CInt32 CompareValue { get; set; }
		[Ordinal(2)]  [RED("variableName")] public CName VariableName { get; set; }

		public animAnimStateTransitionCondition_IntVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
