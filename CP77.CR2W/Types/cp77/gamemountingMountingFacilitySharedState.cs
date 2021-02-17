using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamemountingMountingFacilitySharedState : ISerializable
	{
		[Ordinal(0)] [RED("children")] public CArray<wCHandle<entEntity>> Children { get; set; }
		[Ordinal(1)] [RED("parents")] public CArray<wCHandle<entEntity>> Parents { get; set; }
		[Ordinal(2)] [RED("slotIds")] public CArray<gamemountingMountingSlotId> SlotIds { get; set; }
		[Ordinal(3)] [RED("parentTypes")] public CArray<CEnum<gameMountingObjectType>> ParentTypes { get; set; }
		[Ordinal(4)] [RED("childTypes")] public CArray<CEnum<gameMountingObjectType>> ChildTypes { get; set; }

		public gamemountingMountingFacilitySharedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
