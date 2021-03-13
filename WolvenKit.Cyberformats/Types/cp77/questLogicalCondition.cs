using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questLogicalCondition : questCondition
	{
		[Ordinal(0)] [RED("operation")] public CEnum<questLogicalOperation> Operation { get; set; }
		[Ordinal(1)] [RED("conditions")] public CArray<CHandle<questIBaseCondition>> Conditions { get; set; }

		public questLogicalCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
