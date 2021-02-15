using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DeviceLinkComponentPS : SharedGameplayPS
	{
		[Ordinal(21)] [RED("parentDevice")] public DeviceLink ParentDevice { get; set; }
		[Ordinal(22)] [RED("isConnected")] public CBool IsConnected { get; set; }
		[Ordinal(23)] [RED("ownerEntityID")] public entEntityID OwnerEntityID { get; set; }

		public DeviceLinkComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
