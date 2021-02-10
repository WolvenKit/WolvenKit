using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CustomActionOperations : DeviceOperations
	{
		[Ordinal(2)]  [RED("customActions")] public SCustomDeviceActionsData CustomActions { get; set; }
		[Ordinal(3)]  [RED("customActionsOperations")] public CArray<SCustomActionOperationData> CustomActionsOperations { get; set; }

		public CustomActionOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
