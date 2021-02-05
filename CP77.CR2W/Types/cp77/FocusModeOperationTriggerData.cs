using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FocusModeOperationTriggerData : DeviceOperationTriggerData
	{
		[Ordinal(0)]  [RED("operationsToExecute")] public CArray<CHandle<OperationExecutionData>> OperationsToExecute { get; set; }
		[Ordinal(1)]  [RED("operationType")] public CEnum<ETriggerOperationType> OperationType { get; set; }
		[Ordinal(2)]  [RED("isLookedAt")] public CBool IsLookedAt { get; set; }

		public FocusModeOperationTriggerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
