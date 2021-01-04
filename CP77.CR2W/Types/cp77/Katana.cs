using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Katana : gameweaponObject
	{
		[Ordinal(0)]  [RED("bentBulletTemplateName")] public CName BentBulletTemplateName { get; set; }
		[Ordinal(1)]  [RED("bulletBendingReferenceSlotName")] public CName BulletBendingReferenceSlotName { get; set; }
		[Ordinal(2)]  [RED("colliderComponent")] public CHandle<entIComponent> ColliderComponent { get; set; }
		[Ordinal(3)]  [RED("slotComponent")] public CHandle<entSlotComponent> SlotComponent { get; set; }

		public Katana(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
