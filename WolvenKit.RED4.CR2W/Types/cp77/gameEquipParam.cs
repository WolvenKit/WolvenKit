using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEquipParam : CVariable
	{
		[Ordinal(0)] [RED("slotID")] public TweakDBID SlotID { get; set; }
		[Ordinal(1)] [RED("itemIDToEquip")] public gameItemID ItemIDToEquip { get; set; }
		[Ordinal(2)] [RED("forceFirstEquip")] public CBool ForceFirstEquip { get; set; }
		[Ordinal(3)] [RED("instant")] public CBool Instant { get; set; }

		public gameEquipParam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
