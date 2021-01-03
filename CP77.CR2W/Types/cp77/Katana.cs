using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
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
