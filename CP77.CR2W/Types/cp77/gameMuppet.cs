using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMuppet : gamePuppetBase
	{
		[Ordinal(0)]  [RED("effectTimeStamp")] public CFloat EffectTimeStamp { get; set; }
		[Ordinal(1)]  [RED("highDamageThreshold")] public CFloat HighDamageThreshold { get; set; }
		[Ordinal(2)]  [RED("hitRepresantation")] public CHandle<entSlotComponent> HitRepresantation { get; set; }
		[Ordinal(3)]  [RED("lowDamageThreshold")] public CFloat LowDamageThreshold { get; set; }
		[Ordinal(4)]  [RED("medDamageThreshold")] public CFloat MedDamageThreshold { get; set; }
		[Ordinal(5)]  [RED("slotComponent")] public CHandle<entSlotComponent> SlotComponent { get; set; }

		public gameMuppet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
