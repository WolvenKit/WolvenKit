using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SFactOperationData : CVariable
	{
		[Ordinal(0)] [RED("factName")] public CName FactName { get; set; }
		[Ordinal(1)] [RED("factValue")] public CInt32 FactValue { get; set; }
		[Ordinal(2)] [RED("operationType")] public CEnum<EMathOperationType> OperationType { get; set; }

		public SFactOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
