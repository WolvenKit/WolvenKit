using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SSensesOperationData : CVariable
	{
		[Ordinal(0)]  [RED("attitudeGroup")] public CName AttitudeGroup { get; set; }
		[Ordinal(1)]  [RED("isActivatorNPC")] public CBool IsActivatorNPC { get; set; }
		[Ordinal(2)]  [RED("isActivatorPlayer")] public CBool IsActivatorPlayer { get; set; }
		[Ordinal(3)]  [RED("operation")] public SBaseDeviceOperationData Operation { get; set; }
		[Ordinal(4)]  [RED("operationType")] public CEnum<ETriggerOperationType> OperationType { get; set; }

		public SSensesOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
