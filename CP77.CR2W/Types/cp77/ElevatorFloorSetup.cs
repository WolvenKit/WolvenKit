using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ElevatorFloorSetup : CVariable
	{
		[Ordinal(0)]  [RED("authorizationTextOverride")] public CString AuthorizationTextOverride { get; set; }
		[Ordinal(1)]  [RED("doorShouldOpenFrontLeftRight")] public CArray<CBool> DoorShouldOpenFrontLeftRight { get; set; }
		[Ordinal(2)]  [RED("floorDisplayName")] public CName FloorDisplayName { get; set; }
		[Ordinal(3)]  [RED("floorMarker")] public NodeRef FloorMarker { get; set; }
		[Ordinal(4)]  [RED("floorName")] public CString FloorName { get; set; }
		[Ordinal(5)]  [RED("isHidden")] public CBool IsHidden { get; set; }
		[Ordinal(6)]  [RED("isInactive")] public CBool IsInactive { get; set; }

		public ElevatorFloorSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
