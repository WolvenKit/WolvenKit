using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DeviceOperationsContainer : IScriptable
	{
		[Ordinal(0)] [RED("operations")] public CArray<CHandle<DeviceOperationBase>> Operations { get; set; }
		[Ordinal(1)] [RED("triggers")] public CArray<CHandle<DeviceOperationsTrigger>> Triggers { get; set; }

		public DeviceOperationsContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
