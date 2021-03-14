using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAssignCharacter_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] [RED("characterRef")] public gameEntityReference CharacterRef { get; set; }
		[Ordinal(1)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
		[Ordinal(2)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(3)] [RED("assign")] public CBool Assign { get; set; }
		[Ordinal(4)] [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(5)] [RED("isInstant")] public CBool IsInstant { get; set; }
		[Ordinal(6)] [RED("entryAnimName")] public CName EntryAnimName { get; set; }
		[Ordinal(7)] [RED("entrySlotName")] public CName EntrySlotName { get; set; }

		public questAssignCharacter_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
