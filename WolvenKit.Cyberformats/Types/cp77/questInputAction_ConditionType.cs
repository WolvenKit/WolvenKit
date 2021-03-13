using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questInputAction_ConditionType : questISystemConditionType
	{
		[Ordinal(0)] [RED("anyInputAction")] public CBool AnyInputAction { get; set; }
		[Ordinal(1)] [RED("inputAction")] public CName InputAction { get; set; }
		[Ordinal(2)] [RED("checkIfButtonAlreadyPressed")] public CBool CheckIfButtonAlreadyPressed { get; set; }
		[Ordinal(3)] [RED("axisAction")] public CBool AxisAction { get; set; }
		[Ordinal(4)] [RED("valueLessThan")] public CFloat ValueLessThan { get; set; }
		[Ordinal(5)] [RED("valueMoreThan")] public CFloat ValueMoreThan { get; set; }

		public questInputAction_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
