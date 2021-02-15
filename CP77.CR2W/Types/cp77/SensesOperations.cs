using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SensesOperations : DeviceOperations
	{
		[Ordinal(2)] [RED("sensesOperations")] public CArray<SSensesOperationData> SensesOperations_ { get; set; }

		public SensesOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
