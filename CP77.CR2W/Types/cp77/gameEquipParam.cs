using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEquipParam : CVariable
	{
		[Ordinal(0)]  [RED("forceFirstEquip")] public CBool ForceFirstEquip { get; set; }
		[Ordinal(1)]  [RED("instant")] public CBool Instant { get; set; }
		[Ordinal(2)]  [RED("itemIDToEquip")] public gameItemID ItemIDToEquip { get; set; }
		[Ordinal(3)]  [RED("slotID")] public TweakDBID SlotID { get; set; }

		public gameEquipParam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
