using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TankTurretComponent : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("attackRecord")] public TweakDBID AttackRecord { get; set; }
		[Ordinal(1)]  [RED("slotComponent1")] public CHandle<entSlotComponent> SlotComponent1 { get; set; }
		[Ordinal(2)]  [RED("slotComponent2")] public CHandle<entSlotComponent> SlotComponent2 { get; set; }
		[Ordinal(3)]  [RED("slotComponentName1")] public CName SlotComponentName1 { get; set; }
		[Ordinal(4)]  [RED("slotComponentName2")] public CName SlotComponentName2 { get; set; }
		[Ordinal(5)]  [RED("slotName1")] public CName SlotName1 { get; set; }
		[Ordinal(6)]  [RED("slotName2")] public CName SlotName2 { get; set; }

		public TankTurretComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
