using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMountDescriptor : CVariable
	{
		[Ordinal(0)]  [RED("initialTransform")] public Transform InitialTransform { get; set; }
		[Ordinal(1)]  [RED("mountType")] public CEnum<gameMountDescriptorMountType> MountType { get; set; }
		[Ordinal(2)]  [RED("parentId")] public entEntityID ParentId { get; set; }
		[Ordinal(3)]  [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(4)]  [RED("state")] public CEnum<gamePuppetVehicleState> State { get; set; }

		public gameMountDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
