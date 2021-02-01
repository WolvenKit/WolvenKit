using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldDeviceRef : CVariable
	{
		[Ordinal(0)]  [RED("componentName")] public CName ComponentName { get; set; }
		[Ordinal(1)]  [RED("deviceClassName")] public CName DeviceClassName { get; set; }
		[Ordinal(2)]  [RED("nodeRef")] public NodeRef NodeRef { get; set; }

		public worldDeviceRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
