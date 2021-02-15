using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamemountingMountingRelationship : CVariable
	{
		[Ordinal(0)] [RED("otherMountableType")] public CEnum<gameMountingObjectType> OtherMountableType { get; set; }
		[Ordinal(1)] [RED("otherObject")] public wCHandle<gameObject> OtherObject { get; set; }
		[Ordinal(2)] [RED("relationshipType")] public CEnum<gameMountingRelationshipType> RelationshipType { get; set; }
		[Ordinal(3)] [RED("slotId")] public gamemountingMountingSlotId SlotId { get; set; }

		public gamemountingMountingRelationship(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
