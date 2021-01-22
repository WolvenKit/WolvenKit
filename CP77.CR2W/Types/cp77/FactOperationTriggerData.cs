using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FactOperationTriggerData : DeviceOperationTriggerData
	{
		[Ordinal(0)]  [RED("callbackID")] public CUInt32 CallbackID { get; set; }
		[Ordinal(1)]  [RED("comparisionType")] public CEnum<EComparisonOperator> ComparisionType { get; set; }
		[Ordinal(2)]  [RED("factName")] public CName FactName { get; set; }
		[Ordinal(3)]  [RED("factValue")] public CInt32 FactValue { get; set; }

		public FactOperationTriggerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
