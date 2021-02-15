using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldDeviceConnections : CVariable
	{
		[Ordinal(0)] [RED("deviceClassName")] public CName DeviceClassName { get; set; }
		[Ordinal(1)] [RED("nodeRefs")] public CArray<NodeRef> NodeRefs { get; set; }

		public worldDeviceConnections(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
