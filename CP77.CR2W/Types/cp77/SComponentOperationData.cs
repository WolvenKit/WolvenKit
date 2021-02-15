using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SComponentOperationData : CVariable
	{
		[Ordinal(0)] [RED("componentName")] public CName ComponentName { get; set; }
		[Ordinal(1)] [RED("operationType")] public CEnum<EComponentOperation> OperationType { get; set; }

		public SComponentOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
