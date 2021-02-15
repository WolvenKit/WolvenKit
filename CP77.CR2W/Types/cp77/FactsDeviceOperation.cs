using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FactsDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] [RED("facts")] public CArray<SFactOperationData> Facts { get; set; }

		public FactsDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
