using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Katana : gameweaponObject
	{
		[Ordinal(57)] [RED("bentBulletTemplateName")] public CName BentBulletTemplateName { get; set; }
		[Ordinal(58)] [RED("bulletBendingReferenceSlotName")] public CName BulletBendingReferenceSlotName { get; set; }
		[Ordinal(59)] [RED("colliderComponent")] public CHandle<entIComponent> ColliderComponent { get; set; }
		[Ordinal(60)] [RED("slotComponent")] public CHandle<entSlotComponent> SlotComponent { get; set; }

		public Katana(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
